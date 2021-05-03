// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.XR.ARFoundation;
// using UnityEngine.XR.ARSubsystems;
// using System.Collections;
// using UnityEngine.UI;

// public class rahul : MonoBehaviour
// {
//     [SerializeField]
//     private Button dressChangingToggle;
//     private int swapCounter = 0;

//     [SerializeField]
//     public DressMaterial[] dress;

//     ARHumanBodyManager m_HumanBodyManager;

// 	void Awake(){

//         m_HumanBodyManager = GetComponent<ARHumanBodyManager>();
//         m_HumanBodyManager.humanBodyPrefab = dress[swapCounter].apparel;

// 	    dressChangingToggle.onClick.AddListener(SwapDress);
// 	    dressChangingToggle.GetComponentInChildren<Text>().text = $"{dress[swapCounter].Name}";


//     }


//     void SwapDress(){
//     	foreach(ARHumanBody human in m_HumanBodyManager.trackables)
//                 {
//                 	Destroy(dress[swapCounter].apparel);
                    
//                 }
//         swapCounter = swapCounter == dress.Length - 1 ? 0 : swapCounter + 1;
//         dressChangingToggle.GetComponentInChildren<Text>().text = $"{dress[swapCounter].Name}";

//         foreach(ARHumanBody human in m_HumanBodyManager.trackables)
//                 {
//                 	Instantiate(dress[swapCounter].apparel,human.transform);
                    
//                 }
// 	    // foreach(ARHumanBody human in m_HumanBodyManager.trackables)
// 	    //         {
// 	    //             human.GetComponent<MeshRenderer>().material = materials[swapCounter].Material;
// 	    //         }

// 	            m_HumanBodyManager.humanBodyPrefab = dress[swapCounter].apparel;

// 	}

// }


// [System.Serializable]
// public class DressMaterial
// {
//     public GameObject apparel;

//     public string Name;
// }
