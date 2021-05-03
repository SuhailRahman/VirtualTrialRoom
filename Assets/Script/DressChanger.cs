// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.XR.ARFoundation;

// public class DressChanger : MonoBehaviour
// {
//      ARHumanBodyManager m_HumanBodyManager;
//      private int swapCounter = 0;

//     [SerializeField]
//     private Button dressChangingToggle;

//     [SerializeField]
//     public FaceMaterial[] materials;

//     void Awake(){

//         m_HumanBodyManager = GetComponent<ARHumanBodyManager>();

//         dressChangingToggle.onClick.AddListener(SwapDress);

//         // m_HumanBodyManager.humanBodyPrefab.GetComponent<MeshRenderer>().material = materials[0].Material;
//     }

//     void SwapDress(){

//         swapCounter = swapCounter == materials.Length - 1 ? 0 : swapCounter + 1;

//         // foreach(ARHumanBody human in m_HumanBodyManager.trackables)
//         //         {
//         //             human.GetComponent<MeshRenderer>().material = materials[swapCounter].Material;
//         //         }

//         //         m_HumanBodyManager.humanBodyPrefab.GetComponent<MeshRenderer>().material = materials[swapCounter].Material;

//         dressChangingToggle.GetComponentInChildren<Text>().text = $"Dress Material ({materials[swapCounter].Name})";

//     }

// }

// [System.Serializable]
// public class FaceMaterial
// {
//     public Material Material;

//     public string Name;
// }
