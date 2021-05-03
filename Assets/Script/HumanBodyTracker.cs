using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections;
using UnityEngine.UI;


public class HumanBodyTracker : MonoBehaviour
{

    [SerializeField]
    [Range(-10.0f, 10.0f)]
    public float skeletonOffsetX = 0;

    [Range(-10.0f, 10.0f)]
    [SerializeField]
    public float skeletonOffsetY = 0;

    [Range(-10.0f, 10.0f)]
    [SerializeField]
    public float skeletonOffsetZ = 0;

    // [SerializeField]
    // [Tooltip("The Skeleton prefab to be controlled.")]
    // private GameObject[] skeletonPrefab;
    
    // private int swapCounter = 0;

    [SerializeField]
    public Dress_Prefab_Material[] dress;

    

    [SerializeField]
    [Tooltip("The ARHumanBodyManager which will produce body tracking events.")]
    private ARHumanBodyManager humanBodyManager;


    //change me
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
                   // TrackableId - A session-unique identifier for trackables in the real-world environment


    public ARHumanBodyManager HumanBodyManagers
    {
        get { return humanBodyManager; }
        set { humanBodyManager = value; }
    }

    // public GameObject SkeletonPrefab
    // {
    //     get { return skeletonPrefab; }
    //     set { skeletonPrefab = value; }
    // }

    [SerializeField]
    public Temporary[] Mytemp; 

    void OnEnable()
    {
        Debug.Assert(humanBodyManager != null, "Human body manager is required.");
        humanBodyManager.humanBodiesChanged += OnHumanBodiesChanged; //The event that is fired when a change to the detected human bodies
    }

    void OnDisable()                    
    {
        if (humanBodyManager != null)
            humanBodyManager.humanBodiesChanged -= OnHumanBodiesChanged;
    }

    void OnHumanBodiesChanged(ARHumanBodiesChangedEventArgs eventArgs)
    {   
        // temp = new GameObject[2];
         HumanBoneController[] humanBoneController ; 
          humanBoneController = new HumanBoneController[dress.Length];

        foreach (var humanBody in eventArgs.added) // Iterating through The list of ARHumanBodys added since the last event
        {
            for (int i = 0 ; i < dress.Length ; i++ )
            {

            if (!skeletonTracker[i].TryGetValue(humanBody.trackableId, out humanBoneController[i]))//Adds a new key to the skeleton tracker 
                                                                                          //if there is a new trackable found 
            {     
                Debug.Log($"Adding a new skeleton [{humanBody.trackableId}].");
                var newSkeletonGO = Instantiate(dress[i].apparel, humanBody.transform);
                // var newSkeletonGO = Instantiate(skeletonPrefab, humanBody.transform); //cloning a variable  
                // var newSkeletonGO2 = Instantiate(skeletonPrefab2, humanBody.transform); //cloning a variable  
                // temp = newSkeletonGO;
                // temp2 = newSkeletonGO2;
                Mytemp[i].apparel = newSkeletonGO;

                humanBoneController[i] = newSkeletonGO.GetComponent<HumanBoneController>();
                
                // add an offset just when the human body is added
                humanBoneController[i].transform.position = humanBoneController[i].transform.position + 
                    new Vector3(skeletonOffsetX, skeletonOffsetY, skeletonOffsetZ);

                skeletonTracker[i].Add(humanBody.trackableId, humanBoneController[i]);
            }

            humanBoneController[i].InitializeSkeletonJoints(); // initalizes the newly added skeleton joints
            humanBoneController[i].ApplyBodyPose(humanBody, Vector3.zero); //Positioning the apparel w.r.t to the user

            // HumanBodyTrackerUI.Instance.humanBodyText.text = $"{this.gameObject.name} {humanBody.name} Position: {humanBody.transform.position}\n"+
            // $"LocalPosition: {humanBody.transform.localPosition}";

            // HumanBodyTrackerUI.Instance.humanBoneControllerText.text = $"{this.gameObject.name} {humanBoneController.name} Position: {humanBoneController.transform.position}\n"+
            // $"LocalPosition: {humanBoneController.transform.localPosition}";
            }

            // foreach ( Temporary t in Mytemp )
            // {
            //     t.temp.SetActive(false);
            // }
            // Mytemp[0].temp.SetActive(true);


        }

        // foreach (var humanBody in eventArgs.updated)
        // {
        //     if (skeletonTracker[0].TryGetValue(humanBody.trackableId, out humanBoneController[0])) //if the trackables are updated
        //     {
        //         humanBoneController[0].ApplyBodyPose(humanBody, Vector3.zero); //Positioning the apparel w.r.t to the user
        //     }

        //     // HumanBodyTrackerUI.Instance.humanBodyText.text = $"{this.gameObject.name} {humanBody.name} Position: {humanBody.transform.position}\n"+
        //     // $"LocalPosition: {humanBody.transform.localPosition}";

        //     // HumanBodyTrackerUI.Instance.humanBoneControllerText.text = $"{this.gameObject.name} {humanBoneController.name} Position: {humanBoneController.transform.position}\n"+
        //     // $"LocalPosition: {humanBoneController.transform.localPosition}";
        // }
 
          foreach (var humanBody in eventArgs.updated)
        {
        	for (int i = 0 ; i < dress.Length ; i++ ){
        		if (skeletonTracker[i].TryGetValue(humanBody.trackableId, out humanBoneController[i])) //if the trackables are updated
            	{
                	humanBoneController[i].ApplyBodyPose(humanBody, Vector3.zero); //Positioning the apparel w.r.t to the user
            	}

        	}

        }  

        foreach (var humanBody in eventArgs.removed)
        {
        	for (int i = 0 ; i < dress.Length ; i++ ){
        		if (skeletonTracker[i].TryGetValue(humanBody.trackableId, out humanBoneController[i])) //if the trackables are updated
            	{
					Destroy(humanBoneController[i].gameObject);
                    skeletonTracker[i].Remove(humanBody.trackableId);            	
                }

        	}

        }  


        // foreach (var humanBody in eventArgs.removed)
        // {
        //     Debug.Log($"Removing a skeleton [{humanBody.trackableId}].");
        //     if (skeletonTracker[0].TryGetValue(humanBody.trackableId, out humanBoneController[0]))
        //     {
        //         Destroy(humanBoneController[0].gameObject);
        //         skeletonTracker[0].Remove(humanBody.trackableId);
        //     }
        // }

        // HumanBodyTrackerUI.Instance.humanBodyTrackerText.text = $"{this.gameObject.name} Position: {this.gameObject.transform.position}\n"+
        //     $"LocalPosition: {this.gameObject.transform.localPosition}";
    }
}
[System.Serializable]
public class Dress_Colour_Material
{
    public Material[] Material;
    // public Material Material;
    public string Name;
}

[System.Serializable]
public class Dress_Prefab_Material
{
    public GameObject apparel;
    public Dress_Colour_Material[] apparel_material;
    public string Name;
}

[System.Serializable]
public class Temporary {
    public GameObject apparel;

}
