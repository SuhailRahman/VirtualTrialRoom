// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.XR.ARFoundation;

// public class material : MonoBehaviour
// {
   
//     [SerializeField]
//     public GameObject parent;

//     private int swapCounter = 0;

//     [SerializeField]
//     private Button dressChangingToggle;

//     [SerializeField]
//     public FaceMaterial[] materials;

//     void Awake(){

//         dressChangingToggle.onClick.AddListener(SwapColor);

//         ChangeMaterial(materials[0].Material);

//     }

//     void SwapColor(){

//         swapCounter = swapCounter == materials.Length - 1 ? 0 : swapCounter + 1;

//         ChangeMaterial(materials[swapCounter].Material);

//         dressChangingToggle.GetComponentInChildren<Text>().text = $"Dress Material ({materials[swapCounter].Name})";

//     }

//     void ChangeMaterial(Material newMat)
//       {
//           Renderer[] children;
//           children = parent.GetComponentsInChildren<Renderer>();
//           foreach (Renderer rend in children)
//           {
//               var mats = new Material[rend.materials.Length];
//               for (var j = 0; j < rend.materials.Length; j++)
//               {
//                   mats[j] = newMat;
//               }
//               rend.materials = mats;
//           }
//       }

// }


// [System.Serializable]
// public class FaceMaterial
// {
//     public Material Material;

//     public string Name;
// }

