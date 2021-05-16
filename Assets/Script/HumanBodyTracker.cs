using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections;
using UnityEngine.UI;


public class HumanBodyTracker : MonoBehaviour
{

    //Offset is the relative positioning of the Apparel with respect to the user
    [SerializeField]
    [Range(-10.0f, 10.0f)]
    public float skeletonOffsetX = 0;

    [Range(-10.0f, 10.0f)]
    [SerializeField]
    public float skeletonOffsetY = 0;

    [Range(-10.0f, 10.0f)]
    [SerializeField]
    public float skeletonOffsetZ = 0;

    [SerializeField]
    public Dress_Prefab_Material[] dress;

    [SerializeField]
    [Tooltip("The ARHumanBodyManager which will produce body tracking events.")]
    private ARHumanBodyManager humanBodyManager;

    //Initiales an array of dictionary to keep track of the Skeleton Joints of the human and the apparel
    //where the key is TrackableId - A session-unique identifier for trackables in the real-world environment
    //and value is HumanBoneController which is a class responsible for initializing and updating the positions 
    //of the Apparel
    public Dictionary<TrackableId, HumanBoneController>[] skeletonTracker = new Dictionary<TrackableId, HumanBoneController>[]
    {
    new Dictionary<TrackableId, HumanBoneController>(),
    new Dictionary<TrackableId, HumanBoneController>(),
    new Dictionary<TrackableId, HumanBoneController>(),
    new Dictionary<TrackableId, HumanBoneController>(),
    new Dictionary<TrackableId, HumanBoneController>(),
    new Dictionary<TrackableId, HumanBoneController>(),
    new Dictionary<TrackableId, HumanBoneController>(),
    new Dictionary<TrackableId, HumanBoneController>()

    }; 

    //initialiazing the Object of ARHumanBodyManager class
    public ARHumanBodyManager HumanBodyManagers
    {
        get { return humanBodyManager; }
        set { humanBodyManager = value; }
    }


    [SerializeField]
    public Clone_Temporary[] clone_temp_var;//Declaring an Object to instantiate Apparels

    //This function is called when the User enters the frame of sight
    void OnEnable()
    {
        Debug.Assert(humanBodyManager != null, "Human body manager is required.");

        //This event is triggered when there is a change to the detected human bodies
        humanBodyManager.humanBodiesChanged += OnHumanBodiesChanged; 
    }

    //This function is called when the User leaves the frame of sight
    void OnDisable()                    
    {
        if (humanBodyManager != null){
            //This event is triggered when there is a change to the detected human bodies
            humanBodyManager.humanBodiesChanged -= OnHumanBodiesChanged;
        }
    }

    void OnHumanBodiesChanged(ARHumanBodiesChangedEventArgs eventArgs)
    {   

        HumanBoneController[] humanBoneController ; //declaring an array of `HumanBoneController` class objects

        humanBoneController = new HumanBoneController[dress.Length];

        //Added events is triggered when the User is detected inside the frame of sight
        foreach (var humanBody in eventArgs.added) // Iterating through The list of ARHumanBodys added since the last event
        {
            for (int i = 0 ; i < dress.Length ; i++ )
            {
            //Caching the Human Body trackables
            if (!skeletonTracker[i].TryGetValue(humanBody.trackableId, out humanBoneController[i]))//Adds a new key to the skeleton tracker 
                                                                                          //if there is a new trackable found 
            {     
                Debug.Log($"Adding a new skeleton [{humanBody.trackableId}].");

                //Creates a clone of the apparel 
                var newSkeletonGO = Instantiate(dress[i].apparel, humanBody.transform);

                clone_temp_var[i].apparel = newSkeletonGO;

                //Gets the HumanBoneController script
                humanBoneController[i] = newSkeletonGO.GetComponent<HumanBoneController>();
                
                // The offset is set to (0,0,0), this ensures that the Apparel gets superimposed onto the user
                humanBoneController[i].transform.position = humanBoneController[i].transform.position + 
                    new Vector3(skeletonOffsetX, skeletonOffsetY, skeletonOffsetZ);

                //adds the newly tracked joint to the dictionary
                skeletonTracker[i].Add(humanBody.trackableId, humanBoneController[i]);
            }

            humanBoneController[i].InitializeSkeletonJoints(); // initalizes the newly added skeleton joints

            humanBoneController[i].ApplyBodyPose(humanBody, Vector3.zero); //Positioning the apparel w.r.t to the user

            }
        }

        //Update event is triggered if the User moves or rotates
        foreach (var humanBody in eventArgs.updated)
        {
            for (int i = 0 ; i < dress.Length ; i++ ){
                if (skeletonTracker[i].TryGetValue(humanBody.trackableId, out humanBoneController[i])) //if the trackables are present in dictionary
                {                                                                                      //then it updates the positions of the apparel
                    humanBoneController[i].ApplyBodyPose(humanBody, Vector3.zero); //Positioning the apparel w.r.t to the user
                }

            }
        
        }  
        //Removed events is triggered if the user leaves the frame of sight
        foreach (var humanBody in eventArgs.removed)
        {
            for (int i = 0 ; i < dress.Length ; i++ ){
                //Deallocating the dictionary and destroying all the apparels when the user leaves the frame
                if (skeletonTracker[i].TryGetValue(humanBody.trackableId, out humanBoneController[i])) 
                {
                    Destroy(humanBoneController[i].gameObject);
                    skeletonTracker[i].Remove(humanBody.trackableId);               
                }
            }
        }  
    }
}

//User defined data type which contains array of Materials and name of the Materials
[System.Serializable]
public class Dress_Colour_Material
{
    public Material[] Material;
    public string Name;
}

//User defined data type which contains the Apparel, Materials and the name of the Apparel
[System.Serializable]
public class Dress_Prefab_Material
{
    public GameObject apparel;
    public Dress_Colour_Material[] apparel_material;
    public string Name;
}

//User defined data type which Stores the Clone of the instantiated Apparel
[System.Serializable]
public class Clone_Temporary {
    public GameObject apparel;
}
