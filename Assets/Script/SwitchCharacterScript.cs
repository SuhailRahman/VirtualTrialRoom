// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.XR.ARFoundation;


// [RequireComponent(typeof(HumanBodyTracker))]

// public class SwitchCharacterScript : MonoBehaviour {

//     private int swapCounter = 0;
//     public  AvatarObject[] avatar_dress;

//     [SerializeField]
//     private Button avatarToggle;

//     private HumanBodyTracker HumanBodyTracker;


// 	// Use this for initialization
// 	void awake () {

//         HumanBodyTracker = GetComponent<HumanBodyTracker>();
// 		// enable first avatar and disable another one
// 		// foreach(AvatarObject dress in avatar_dress)
//   //               {
//   //               	dress.avatar.gameObject.SetActive (false);
//   //               }
//   //              avatar_dress[0].avatar.gameObject.SetActive (true);

//         avatarToggle.onClick.AddListener(SwitchAvatar);

//         HumanBodyTracker.skeletonPrefab = avatar_dress[0].avatar;
//         avatarToggle.GetComponentInChildren<Text>().text = $"Dress Material ({avatar_dress[0].Name})";
// 	}

// 	void SwitchAvatar(){
//         // avatar_dress[swapCounter].avatar.gameObject.SetActive(false);

//         swapCounter = swapCounter == avatar_dress.Length - 1 ? 0 : swapCounter + 1;

//         // avatar_dress[swapCounter].avatar.gameObject.SetActive(true);

//         HumanBodyTracker.skeletonPrefab = avatar_dress[swapCounter].avatar;
//         avatarToggle.GetComponentInChildren<Text>().text = $"Dress Material ({avatar_dress[swapCounter].Name})";

      
//     }
    



// }
// [System.Serializable]
// public class AvatarObject
// {
//     public GameObject avatar;

//     public string Name;
// }
