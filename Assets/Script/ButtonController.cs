using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

    [SerializeField]
    private Button dress_changing_button;
    private int dress_swap_counter = 0;

    [SerializeField]
    private Button material_changing_button;
    private int material_swap_counter = 0; 

    //Declaring `HumanBodyTracker` object
    HumanBodyTracker HumanBodyTracker_object;

    //This function is called before the HumanBodyTracker Class and HumanBoneContoller Class
    void Awake(){

        HumanBodyTracker_object = GetComponent<HumanBodyTracker>();

        //When the `dress_changing_button` is clicked, `SwapDress` function is called
        dress_changing_button.onClick.AddListener(SwapDress);

        //When the  `material_changing_button` is clicked, `SwapMaterial` function is called 
        material_changing_button.onClick.AddListener(SwapMaterial);

        //The button name is set as the first Apparel name
        dress_changing_button.GetComponentInChildren<Text>().text = $"{HumanBodyTracker_object.dress[dress_swap_counter].Name}";

    }

    void SwapDress(){
        
        //increments the `dress_swap_counter` by 1 and resets the counter to 0 if the `dress_swap_counter` is equal to the 
        //length of the array
        dress_swap_counter = dress_swap_counter == HumanBodyTracker_object.dress.Length - 1 ? 0 : dress_swap_counter + 1;

        //Sets all the apparels inactive/hidden
        foreach ( Clone_Temporary t in HumanBodyTracker_object.clone_temp_var )
        {
            t.apparel.SetActive(false);
        }
        //Displays the current apparel 
        HumanBodyTracker_object.clone_temp_var[dress_swap_counter].apparel.SetActive(true);

        //The button name is set as the current Apparel name
        dress_changing_button.GetComponentInChildren<Text>().text = $"{HumanBodyTracker_object.dress[dress_swap_counter].Name}";
    }

    void SwapMaterial()
    {
            
            //increments the `material_swap_counter` by 1 and resets the counter to 0 if the `material_swap_counter` is equal to the 
            //length of the array
            material_swap_counter = material_swap_counter == HumanBodyTracker_object.dress[dress_swap_counter].apparel_material.Length - 1 ? 0 : material_swap_counter + 1;
            
            //swaps the previous material of the apparel with the current one
            HumanBodyTracker_object.clone_temp_var[dress_swap_counter].apparel.GetComponentInChildren<SkinnedMeshRenderer>().sharedMaterials=HumanBodyTracker_object.dress[dress_swap_counter].apparel_material[material_swap_counter].Material;
            
            //The button name is set as the current Material name
            material_changing_button.GetComponentInChildren<Text>().text = $"{HumanBodyTracker_object.dress[dress_swap_counter].apparel_material[material_swap_counter].Name}";
 
    }
}