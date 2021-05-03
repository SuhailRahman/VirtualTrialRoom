using UnityEngine.XR.ARFoundation;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;
using System;

public class HumanBoneController : MonoBehaviour
{
    // 3D joint skeleton
    public enum JointIndices
    {
        Invalid = -1,
        Root = 0, // parent: <none> [-1]
        Hips = 1, // parent: Root [0]
        LeftUpLeg = 2, // parent: Hips [1]
        LeftLeg = 3, // parent: LeftUpLeg [2]
        LeftFoot = 4, // parent: LeftLeg [3]
        LeftToes = 5, // parent: LeftFoot [4]
        LeftToesEnd = 6, // parent: LeftToes [5]
        RightUpLeg = 7, // parent: Hips [1]
        RightLeg = 8, // parent: RightUpLeg [7]
        RightFoot = 9, // parent: RightLeg [8]
        RightToes = 10, // parent: RightFoot [9]
        RightToesEnd = 11, // parent: RightToes [10]
        Spine1 = 12, // parent: Hips [1]
        Spine2 = 13, // parent: Spine1 [12]
        Spine3 = 14, // parent: Spine2 [13]
        Spine4 = 15, // parent: Spine3 [14]
        Spine5 = 16, // parent: Spine4 [15]
        Spine6 = 17, // parent: Spine5 [16]
        Spine7 = 18, // parent: Spine6 [17]
        LeftShoulder1 = 19, // parent: Spine7 [18]
        LeftArm = 20, // parent: LeftShoulder1 [19]
        LeftForearm = 21, // parent: LeftArm [20]
        LeftHand = 22, // parent: LeftForearm [21]
        LeftHandIndexStart = 23, // parent: LeftHand [22]
        LeftHandIndex1 = 24, // parent: LeftHandIndexStart [23]
        LeftHandIndex2 = 25, // parent: LeftHandIndex1 [24]
        LeftHandIndex3 = 26, // parent: LeftHandIndex2 [25]
        LeftHandIndexEnd = 27, // parent: LeftHandIndex3 [26]
        LeftHandMidStart = 28, // parent: LeftHand [22]
        LeftHandMid1 = 29, // parent: LeftHandMidStart [28]
        LeftHandMid2 = 30, // parent: LeftHandMid1 [29]
        LeftHandMid3 = 31, // parent: LeftHandMid2 [30]
        LeftHandMidEnd = 32, // parent: LeftHandMid3 [31]
        LeftHandPinkyStart = 33, // parent: LeftHand [22]
        LeftHandPinky1 = 34, // parent: LeftHandPinkyStart [33]
        LeftHandPinky2 = 35, // parent: LeftHandPinky1 [34]
        LeftHandPinky3 = 36, // parent: LeftHandPinky2 [35]
        LeftHandPinkyEnd = 37, // parent: LeftHandPinky3 [36]
        LeftHandRingStart = 38, // parent: LeftHand [22]
        LeftHandRing1 = 39, // parent: LeftHandRingStart [38]
        LeftHandRing2 = 40, // parent: LeftHandRing1 [39]
        LeftHandRing3 = 41, // parent: LeftHandRing2 [40]
        LeftHandRingEnd = 42, // parent: LeftHandRing3 [41]
        LeftHandThumbStart = 43, // parent: LeftHand [22]
        LeftHandThumb1 = 44, // parent: LeftHandThumbStart [43]
        LeftHandThumb2 = 45, // parent: LeftHandThumb1 [44]
        LeftHandThumbEnd = 46, // parent: LeftHandThumb2 [45]
        Neck1 = 47, // parent: Spine7 [18]
        Neck2 = 48, // parent: Neck1 [47]
        Neck3 = 49, // parent: Neck2 [48]
        Neck4 = 50, // parent: Neck3 [49]
        Head = 51, // parent: Neck4 [50]
        Jaw = 52, // parent: Head [51]
        Chin = 53, // parent: Jaw [52]
        LeftEye = 54, // parent: Head [51]
        LeftEyeLowerLid = 55, // parent: LeftEye [54]
        LeftEyeUpperLid = 56, // parent: LeftEye [54]
        LeftEyeball = 57, // parent: LeftEye [54]
        Nose = 58, // parent: Head [51]
        RightEye = 59, // parent: Head [51]
        RightEyeLowerLid = 60, // parent: RightEye [59]
        RightEyeUpperLid = 61, // parent: RightEye [59]
        RightEyeball = 62, // parent: RightEye [59]
        RightShoulder1 = 63, // parent: Spine7 [18]
        RightArm = 64, // parent: RightShoulder1 [63]
        RightForearm = 65, // parent: RightArm [64]
        RightHand = 66, // parent: RightForearm [65]
        RightHandIndexStart = 67, // parent: RightHand [66]
        RightHandIndex1 = 68, // parent: RightHandIndexStart [67]
        RightHandIndex2 = 69, // parent: RightHandIndex1 [68]
        RightHandIndex3 = 70, // parent: RightHandIndex2 [69]
        RightHandIndexEnd = 71, // parent: RightHandIndex3 [70]
        RightHandMidStart = 72, // parent: RightHand [66]
        RightHandMid1 = 73, // parent: RightHandMidStart [72]
        RightHandMid2 = 74, // parent: RightHandMid1 [73]
        RightHandMid3 = 75, // parent: RightHandMid2 [74]
        RightHandMidEnd = 76, // parent: RightHandMid3 [75]
        RightHandPinkyStart = 77, // parent: RightHand [66]
        RightHandPinky1 = 78, // parent: RightHandPinkyStart [77]
        RightHandPinky2 = 79, // parent: RightHandPinky1 [78]
        RightHandPinky3 = 80, // parent: RightHandPinky2 [79]
        RightHandPinkyEnd = 81, // parent: RightHandPinky3 [80]
        RightHandRingStart = 82, // parent: RightHand [66]
        RightHandRing1 = 83, // parent: RightHandRingStart [82]
        RightHandRing2 = 84, // parent: RightHandRing1 [83]
        RightHandRing3 = 85, // parent: RightHandRing2 [84]
        RightHandRingEnd = 86, // parent: RightHandRing3 [85]
        RightHandThumbStart = 87, // parent: RightHand [66]
        RightHandThumb1 = 88, // parent: RightHandThumbStart [87]
        RightHandThumb2 = 89, // parent: RightHandThumb1 [88]
        RightHandThumbEnd = 90, // parent: RightHandThumb2 [89]
    }

    // // 3D joint skeleton
    //     public enum JointIndices
    //     {
    //         Invalid = -1,
    //         root = 0, // parent: <none> [-1]
    //         hips_joint = 1, // parent: Root [0]
    //         left_upLeg_joint = 2, // parent: Hips [1]
    //         left_leg_joint = 3, // parent: LeftUpLeg [2]
    //         left_foot_joint = 4, // parent: LeftLeg [3]
    //         left_toes_joint = 5, // parent: LeftFoot [4]
    //         left_toesEnd_joint = 6, // parent: LeftToes [5]
    //         right_upLeg_joint = 7, // parent: Hips [1]
    //         right_leg_joint = 8, // parent: RightUpLeg [7]
    //         right_foot_joint = 9, // parent: RightLeg [8]
    //         right_toes_joint = 10, // parent: RightFoot [9]
    //         right_toesEnd_joint = 11, // parent: RightToes [10]
    //         spine_1_joint = 12, // parent: Hips [1]
    //         spine_2_joint = 13, // parent: Spine1 [12]
    //         spine_3_joint = 14, // parent: Spine2 [13]
    //         spine_4_joint = 15, // parent: Spine3 [14]
    //         spine_5_joint = 16, // parent: Spine4 [15]
    //         spine_6_joint = 17, // parent: Spine5 [16]
    //         spine_7_joint = 18, // parent: Spine6 [17]
    //         left_shoulder_1_joint = 19, // parent: Spine7 [18]
    //         left_arm_joint = 20, // parent: LeftShoulder1 [19]
    //         left_forearm_joint = 21, // parent: LeftArm [20]
    //         left_hand_joint = 22, // parent: LeftForearm [21]
    //         left_handIndexStart_joint = 23, // parent: LeftHand [22]
    //         left_handIndex_1_joint = 24, // parent: LeftHandIndexStart [23]
    //         left_handIndex_2_joint = 25, // parent: LeftHandIndex1 [24]
    //         left_handIndex_3_joint = 26, // parent: LeftHandIndex2 [25]
    //         left_handIndexEnd_joint = 27, // parent: LeftHandIndex3 [26]
    //         left_handMidStart_joint = 28, // parent: LeftHand [22]
    //         left_handMid_1_joint = 29, // parent: LeftHandMidStart [28]
    //         left_handMid_2_joint = 30, // parent: LeftHandMid1 [29]
    //         left_handMid_3_joint = 31, // parent: LeftHandMid2 [30]
    //         left_handMidEnd_joint = 32, // parent: LeftHandMid3 [31]
    //         left_handPinkyStart_joint = 33, // parent: LeftHand [22]
    //         left_handPinky_1_joint = 34, // parent: LeftHandPinkyStart [33]
    //         left_handPinky_2_joint = 35, // parent: LeftHandPinky1 [34]
    //         left_handPinky_3_joint = 36, // parent: LeftHandPinky2 [35]
    //         left_handPinkyEnd_joint = 37, // parent: LeftHandPinky3 [36]
    //         left_handRingStart_joint = 38, // parent: LeftHand [22]
    //         left_handRing_1_joint = 39, // parent: LeftHandRingStart [38]
    //         left_handRing_2_joint = 40, // parent: LeftHandRing1 [39]
    //         left_handRing_3_joint = 41, // parent: LeftHandRing2 [40]
    //         left_handRingEnd_joint = 42, // parent: LeftHandRing3 [41]
    //         left_handThumbStart_joint = 43, // parent: LeftHand [22]
    //         left_handThumb_1_joint = 44, // parent: LeftHandThumbStart [43]
    //         left_handThumb_2_joint = 45, // parent: LeftHandThumb1 [44]
    //         left_handThumbEnd_joint = 46, // parent: LeftHandThumb2 [45]
    //         neck_1_joint = 47, // parent: Spine7 [18]
    //         neck_2_joint = 48, // parent: Neck1 [47]
    //         neck_3_joint = 49, // parent: Neck2 [48]
    //         neck_4_joint = 50, // parent: Neck3 [49]
    //         head_joint = 51, // parent: Neck4 [50]
    //         jaw_joint = 52, // parent: Head [51]
    //         chin_joint = 53, // parent: Jaw [52]
    //         left_eye_joint = 54, // parent: Head [51]
    //         left_eyeLowerLid_joint = 55, // parent: LeftEye [54]
    //         left_eyeUpperLid_joint = 56, // parent: LeftEye [54]
    //         left_eyeball_joint = 57, // parent: LeftEye [54]
    //         nose_joint = 58, // parent: Head [51]
    //         right_eye_joint = 59, // parent: Head [51]
    //         right_eyeLowerLid_joint = 60, // parent: RightEye [59]
    //         right_eyeUpperLid_joint = 61, // parent: RightEye [59]
    //         right_eyeball_joint = 62, // parent: RightEye [59]
    //         right_shoulder_1_joint = 63, // parent: Spine7 [18]
    //         right_arm_joint = 64, // parent: RightShoulder1 [63]
    //         right_forearm_joint = 65, // parent: RightArm [64]
    //         right_hand_joint = 66, // parent: RightForearm [65]
    //         right_handIndexStart_joint = 67, // parent: RightHand [66]
    //         right_handIndex_1_joint = 68, // parent: RightHandIndexStart [67]
    //         right_handIndex_2_joint = 69, // parent: RightHandIndex1 [68]
    //         right_handIndex_3_joint = 70, // parent: RightHandIndex2 [69]
    //         right_handIndexEnd_joint = 71, // parent: RightHandIndex3 [70]
    //         right_handMidStart_joint = 72, // parent: RightHand [66]
    //         right_handMid_1_joint = 73, // parent: RightHandMidStart [72]
    //         right_handMid_2_joint = 74, // parent: RightHandMid1 [73]
    //         right_handMid_3_joint = 75, // parent: RightHandMid2 [74]
    //         right_handMidEnd_joint = 76, // parent: RightHandMid3 [75]
    //         right_handPinkyStart_joint = 77, // parent: RightHand [66]
    //         right_handPinky_1_joint = 78, // parent: RightHandPinkyStart [77]
    //         right_handPinky_2_joint = 79, // parent: RightHandPinky1 [78]
    //         right_handPinky_3_joint = 80, // parent: RightHandPinky2 [79]
    //         right_handPinkyEnd_joint = 81, // parent: RightHandPinky3 [80]
    //         right_handRingStart_joint = 82, // parent: RightHand [66]
    //         right_handRing_1_joint = 83, // parent: RightHandRingStart [82]
    //         right_handRing_2_joint = 84, // parent: RightHandRing1 [83]
    //         right_handRing_3_joint = 85, // parent: RightHandRing2 [84]
    //         right_handRingEnd_joint = 86, // parent: RightHandRing3 [85]
    //         right_handThumbStart_joint = 87, // parent: RightHand [66]
    //         right_handThumb_1_joint = 88, // parent: RightHandThumbStart [87]
    //         right_handThumb_2_joint = 89, // parent: RightHandThumb1 [88]
    //         right_handThumbEnd_joint = 90, // parent: RightHandThumb2 [89]
    //     }
    const int k_NumSkeletonJoints = 91;

    [SerializeField]
    [Tooltip("The root bone of the skeleton.")]
    Transform m_SkeletonRoot;

    /// <summary>
    /// Get/Set the root bone of the skeleton.
    /// </summary>
    public Transform skeletonRoot
    {
        get
        {
            return m_SkeletonRoot;
        }
        set
        {
            m_SkeletonRoot = value;
        }
    }

    Transform[] m_BoneMapping = new Transform[k_NumSkeletonJoints];

    public void InitializeSkeletonJoints()
    {
        // Walk through all the child joints in the skeleton and
        // store the skeleton joints at the corresponding index in the m_BoneMapping array.
        // This assumes that the bones in the skeleton are named as per the
        // JointIndices enum above.
        Queue<Transform> nodes = new Queue<Transform>();
        nodes.Enqueue(m_SkeletonRoot);
        while (nodes.Count > 0)
        {
            Transform next = nodes.Dequeue();
            for (int i = 0; i < next.childCount; ++i)
            {
                nodes.Enqueue(next.GetChild(i));
            }
            ProcessJoint(next);
        }
    }

    public void ApplyBodyPose(ARHumanBody body, Vector3 offset)
    {
        var joints = body.joints;
        if (!joints.IsCreated)
            return;

        for (int i = 0; i < k_NumSkeletonJoints; ++i)
        {
            XRHumanBodyJoint joint = joints[i];
            var bone = m_BoneMapping[i];
            if (bone != null)
            {
                bone.transform.localPosition = joint.localPose.position + offset;
                bone.transform.localRotation = joint.localPose.rotation;
            }
        }
    }

    void ProcessJoint(Transform joint)
    {
        int index = GetJointIndex(joint.name);
        if (index >= 0 && index < k_NumSkeletonJoints)
        {
            m_BoneMapping[index] = joint;
        }
        else
        {
            Debug.LogWarning($"{joint.name} was not found.");
        }
    }

    // Returns the integer value corresponding to the JointIndices enum value
    // passed in as a string.
    int GetJointIndex(string jointName)
    {
        JointIndices val;
        if (Enum.TryParse(jointName, out val))
        {
            return (int)val;
        }
        return -1;
    }
}
