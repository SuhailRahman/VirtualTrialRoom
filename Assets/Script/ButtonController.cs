using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

    // public Material[] mats =  new Material[3];

    [SerializeField]
    private Button dressChangingToggle;
    private int dress_swapCounter = 0;

    [SerializeField]
    private Button MaterialChangingToggle;
    private int material_swapCounter = 0; 

    // [SerializeField]
    // public Dress_Prefab_Material[] dress;

    // [SerializeField]
    // public Dress_Colour_Material [] materials;

    HumanBodyTracker skel;

    // public bool val = true;
	void Awake(){

		skel = GetComponent<HumanBodyTracker>();

        dressChangingToggle.onClick.AddListener(SwapDress);

        MaterialChangingToggle.onClick.AddListener(SwapMaterial);

        // ChangeMaterial(materials[0].Material);

        dressChangingToggle.GetComponentInChildren<Text>().text = $"{skel.dress[dress_swapCounter].Name}";

        //MaterialChangingToggle.GetComponentInChildren<Text>().text = $"{materials[material_swapCounter].Name}";
        // skel.SkeletonPrefab =dress[swapCounter].apparel;
        // foreach ( Temporary t in skel.Mytemp )
        // {
        // 	t.temp.SetActive(false);
        // }
        // skel.Mytemp[swapCounter].temp.SetActive(true);

    }

    void SwapDress(){
    	
        // skel.temp.SetActive(!val);
        // skel.Mytemp[swapCounter].temp.SetActive(false);
        dress_swapCounter = dress_swapCounter == skel.dress.Length - 1 ? 0 : dress_swapCounter + 1;
        // skel.Mytemp[swapCounter].temp.SetActive(true);
        foreach ( Temporary t in skel.Mytemp )
        {
        	t.apparel.SetActive(false);
        }
        skel.Mytemp[dress_swapCounter].apparel.SetActive(true);

        dressChangingToggle.GetComponentInChildren<Text>().text = $"{skel.dress[dress_swapCounter].Name}";
        // skel.SkeletonPrefab=dress[swapCounter].apparel;
        // foreach(ARHumanBody human in skel.HumanBodyManagers.trackables)
        //         {
        //         	Instantiate(dress[swapCounter].apparel,human.transform);
                    
        //         }
	}

	void SwapMaterial()
	{
		
        if(skel.dress[dress_swapCounter].Name == "Balerina"){
            MaterialChangingToggle.GetComponentInChildren<Text>().text = "Purple";
        }
        else
        {
            material_swapCounter = material_swapCounter == skel.dress[dress_swapCounter].apparel_material.Length - 1 ? 0 : material_swapCounter + 1;
            skel.Mytemp[dress_swapCounter].apparel.GetComponentInChildren<SkinnedMeshRenderer>().sharedMaterials=skel.dress[dress_swapCounter].apparel_material[material_swapCounter].Material;
            MaterialChangingToggle.GetComponentInChildren<Text>().text = $"{skel.dress[dress_swapCounter].apparel_material[material_swapCounter].Name}";
        }
        // ChangeMaterial(skel.dress[dress_swapCounter].apparel_material[material_swapCounter].Material);

        //Material[] mats = new Materials[]{mat,bat,cat};
      // if(skel.dress[dress_swapCounter].Name == "A"){
            // skel.dress[dress_swapCounter].apparel.GetComponent<SkinnedMeshRenderer>().sharedMaterials=mats;

          //skel.dress[dress_swapCounter].apparel_material[material_swapCounter].Material;
          // MaterialChangingToggle.GetComponentInChildren<Text>().text = $"{skel.dress[dress_swapCounter].apparel.transform.Find("ace_PLY").gameObject.GetComponent<SkinnedMeshRenderer>().sharedMaterials}";

      // }

        // if(skel.dress[dress_swapCounter].Name == "A"){
        //   foreach (Transform child in skel.dress[dress_swapCounter].apparel.transform)
        //   {
        //       if (child.tag == "suhail"){
        //           child.gameObject.GetComponent<SkinnedMeshRenderer>().sharedMaterials[0]=mat;
        //           //skel.dress[dress_swapCounter].apparel_material[material_swapCounter].Material;
        //           MaterialChangingToggle.GetComponentInChildren<Text>().text = $"{child.gameObject.GetComponent<SkinnedMeshRenderer>().sharedMaterials[0]}";

        //       }

        //   }
        //GameObject new_mat = skel.Mytemp[dress_swapCounter].apparel.transform.Find("ace_PLY").gameObject;
        //new_mat.GetComponent<SkinnedMeshRenderer>().materials[0]=skel.dress[dress_swapCounter].apparel_material[material_swapCounter].Material;
        //skel.Mytemp[dress_swapCounter].apparel.transform.Find("ace_PLY").gameObject.GetComponent<SkinnedMeshRenderer>().materials[2]=skel.dress[dress_swapCounter].apparel_material[material_swapCounter].Material;
        // }
        // MaterialChangingToggle.GetComponentInChildren<Text>().text = $"{skel.dress[dress_swapCounter].apparel_material[material_swapCounter].Name}";
	}

	// void ChangeMaterial(Material newMat)
 //      {
 //          Renderer[] children;
 //          children = skel.Mytemp[dress_swapCounter].apparel.GetComponentsInChildren<Renderer>();
 //          // children = parent.GetComponentsInChildren<Renderer>();
 //          foreach (Renderer rend in children)
 //          {
 //              var mats = new Material[rend.sharedMaterials.Length];
 //              for (var j = 0; j < rend.sharedMaterials.Length; j++)
 //              {
 //                  mats[j] = newMat;
 //              }
 //              rend.sharedMaterials = mats;
 //          }
 //      }
}


// [System.Serializable]
// public class Dress_Colour_Material   
// {
//     public Material Material;

//     public string Name;
// }
// [System.Serializable]
// public class Dress_Prefab_Material
// {
//     public GameObject apparel;

//     public string Name;
// }

