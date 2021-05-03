using System;
using System.Runtime.InteropServices;

namespace UnityEngine.XR.ARKit
{
    /// <summary>
    /// Enum values that represent face action units that affect the expression on the face
    /// </summary>
    public enum ARKitBlendShapeLocation
    {
        /// <summary>
        /// The coefficient describing downward movement of the outer portion of the left eyebrow.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationbrowdownleft).
        /// </summary>
        BrowDownLeft,

        /// <summary>
        /// The coefficient describing downward movement of the outer portion of the right eyebrow.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationbrowdownright).
        /// </summary>
        BrowDownRight,

        /// <summary>
        /// The coefficient describing upward movement of the inner portion of both eyebrows.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationbrowinnerup).
        /// </summary>
        BrowInnerUp,

        /// <summary>
        /// The coefficient describing upward movement of the outer portion of the left eyebrow.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationbrowouterupleft).
        /// </summary>
        BrowOuterUpLeft,

        /// <summary>
        /// The coefficient describing upward movement of the outer portion of the right eyebrow.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationbrowouterupright).
        /// </summary>
        BrowOuterUpRight,

        /// <summary>
        /// The coefficient describing outward movement of both cheeks.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationcheekpuff).
        /// </summary>
        CheekPuff,

        /// <summary>
        /// The coefficient describing upward movement of the cheek around and below the left eye.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationcheeksquintleft).
        /// </summary>
        CheekSquintLeft,

        /// <summary>
        /// The coefficient describing upward movement of the cheek around and below the right eye.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationcheeksquintright).
        /// </summary>
        CheekSquintRight,

        /// <summary>
        /// The coefficient describing closure of the eyelids over the left eye.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationeyeblinkleft).
        /// </summary>
        EyeBlinkLeft,

        /// <summary>
        /// The coefficient describing closure of the eyelids over the right eye.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationeyeblinkright).
        /// </summary>
        EyeBlinkRight,

        /// <summary>
        /// The coefficient describing movement of the left eyelids consistent with a downward gaze.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationeyelookdownleft).
        /// </summary>
        EyeLookDownLeft,

        /// <summary>
        /// The coefficient describing movement of the right eyelids consistent with a downward gaze.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationeyelookdownright).
        /// </summary>
        EyeLookDownRight,

        /// <summary>
        /// The coefficient describing movement of the left eyelids consistent with a rightward gaze.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationeyelookinleft).
        /// </summary>
        EyeLookInLeft,

        /// <summary>
        /// The coefficient describing movement of the right eyelids consistent with a leftward gaze.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationeyelookinright).
        /// </summary>
        EyeLookInRight,

        /// <summary>
        /// The coefficient describing movement of the left eyelids consistent with a leftward gaze.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationeyelookoutleft).
        /// </summary>
        EyeLookOutLeft,

        /// <summary>
        /// The coefficient describing movement of the right eyelids consistent with a rightward gaze.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationeyelookoutright).
        /// </summary>
        EyeLookOutRight,

        /// <summary>
        /// The coefficient describing movement of the left eyelids consistent with an upward gaze.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationeyelookupleft).
        /// </summary>
        EyeLookUpLeft,

        /// <summary>
        /// The coefficient describing movement of the right eyelids consistent with an upward gaze.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationeyelookupright).
        /// </summary>
        EyeLookUpRight,

        /// <summary>
        /// The coefficient describing contraction of the face around the left eye.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationeyesquintleft).
        /// </summary>
        EyeSquintLeft,

        /// <summary>
        /// The coefficient describing contraction of the face around the right eye.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationeyesquintright).
        /// </summary>
        EyeSquintRight,

        /// <summary>
        /// The coefficient describing a widening of the eyelids around the left eye.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationeyewideleft).
        /// </summary>
        EyeWideLeft,

        /// <summary>
        /// The coefficient describing a widening of the eyelids around the right eye.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationeyewideright).
        /// </summary>
        EyeWideRight,

        /// <summary>
        /// The coefficient describing forward movement of the lower jaw.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationjawforward).
        /// </summary>
        JawForward,

        /// <summary>
        /// The coefficient describing leftward movement of the lower jaw.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationjawleft).
        /// </summary>
        JawLeft,

        /// <summary>
        /// The coefficient describing an opening of the lower jaw.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationjawopen).
        /// </summary>
        JawOpen,

        /// <summary>
        /// The coefficient describing rightward movement of the lower jaw.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationjawright).
        /// </summary>
        JawRight,

        /// <summary>
        /// The coefficient describing closure of the lips independent of jaw position.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthclose).
        /// </summary>
        MouthClose,

        /// <summary>
        /// The coefficient describing backward movement of the left corner of the mouth.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthdimpleleft).
        /// </summary>
        MouthDimpleLeft,

        /// <summary>
        /// The coefficient describing backward movement of the right corner of the mouth.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthdimpleright).
        /// </summary>
        MouthDimpleRight,

        /// <summary>
        /// The coefficient describing downward movement of the left corner of the mouth.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthfrownleft).
        /// </summary>
        MouthFrownLeft,

        /// <summary>
        /// The coefficient describing downward movement of the right corner of the mouth.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthfrownright).
        /// </summary>
        MouthFrownRight,

        /// <summary>
        /// The coefficient describing contraction of both lips into an open shape.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthfunnel).
        /// </summary>
        MouthFunnel,

        /// <summary>
        /// The coefficient describing leftward movement of both lips together.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthleft).
        /// </summary>
        MouthLeft,

        /// <summary>
        /// The coefficient describing downward movement of the lower lip on the left side.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthlowerdownleft).
        /// </summary>
        MouthLowerDownLeft,

        /// <summary>
        /// The coefficient describing downward movement of the lower lip on the right side.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthlowerdownright).
        /// </summary>
        MouthLowerDownRight,

        /// <summary>
        /// The coefficient describing upward compression of the lower lip on the left side.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthpressleft).
        /// </summary>
        MouthPressLeft,

        /// <summary>
        /// The coefficient describing upward compression of the lower lip on the right side.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthpressright).
        /// </summary>
        MouthPressRight,

        /// <summary>
        /// The coefficient describing contraction and compression of both closed lips.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthpucker).
        /// </summary>
        MouthPucker,

        /// <summary>
        /// The coefficient describing rightward movement of both lips together.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthright).
        /// </summary>
        MouthRight,

        /// <summary>
        /// The coefficient describing movement of the lower lip toward the inside of the mouth.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthrolllower).
        /// </summary>
        MouthRollLower,

        /// <summary>
        /// The coefficient describing movement of the upper lip toward the inside of the mouth.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthrollupper).
        /// </summary>
        MouthRollUpper,

        /// <summary>
        /// The coefficient describing outward movement of the lower lip.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthshruglower).
        /// </summary>
        MouthShrugLower,

        /// <summary>
        /// The coefficient describing outward movement of the upper lip.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthshrugupper).
        /// </summary>
        MouthShrugUpper,

        /// <summary>
        /// The coefficient describing upward movement of the left corner of the mouth.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthsmileleft).
        /// </summary>
        MouthSmileLeft,

        /// <summary>
        /// The coefficient describing upward movement of the right corner of the mouth.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthsmileright).
        /// </summary>
        MouthSmileRight,

        /// <summary>
        /// The coefficient describing leftward movement of the left corner of the mouth.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthstretchleft).
        /// </summary>
        MouthStretchLeft,

        /// <summary>
        /// The coefficient describing rightward movement of the left corner of the mouth.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthstretchright).
        /// </summary>
        MouthStretchRight,

        /// <summary>
        /// The coefficient describing upward movement of the upper lip on the left side.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthupperupleft).
        /// </summary>
        MouthUpperUpLeft,

        /// <summary>
        /// The coefficient describing upward movement of the upper lip on the right side.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationmouthupperupright).
        /// </summary>
        MouthUpperUpRight,

        /// <summary>
        /// The coefficient describing a raising of the left side of the nose around the nostril.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationnosesneerleft).
        /// </summary>
        NoseSneerLeft,

        /// <summary>
        /// The coefficient describing a raising of the right side of the nose around the nostril.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationnosesneerright).
        /// </summary>
        NoseSneerRight,

        /// <summary>
        /// The coefficient describing extension of the tongue.
        /// For more information, please refer to the
        /// [ARKit documentation](https://developer.apple.com/documentation/arkit/arblendshapelocationtongueout).
        /// </summary>
        TongueOut
    }

    /// <summary>
    /// An entry that specifies how much of a specific <see cref="ARKitBlendShapeLocation"/> is present in the current expression on the face.
    /// </summary>
    /// <remarks>
    /// You get a list of these for every expression a face makes.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ARKitBlendShapeCoefficient : IEquatable<ARKitBlendShapeCoefficient>
    {
        // Fields to marshall/serialize from native code
        ARKitBlendShapeLocation m_BlendShapeLocation;
        float m_Coefficient;

        /// <summary>
        /// The specific <see cref="ARKitBlendShapeLocation"/> being examined.
        /// </summary>
        public ARKitBlendShapeLocation blendShapeLocation => m_BlendShapeLocation;

        /// <summary>
        /// A value from 0.0 to 1.0 that specifies how active the associated <see cref="ARKitBlendShapeLocation"/> is in this expression.
        /// </summary>
        public float coefficient => m_Coefficient;

        /// <summary>
        /// Tests for equality.
        /// </summary>
        /// <param name="other">The other <see cref="ARKitBlendShapeCoefficient"/> to compare against.</param>
        /// <returns>`True` if every field in <paramref name="other"/> is equal to this <see cref="ARKitBlendShapeCoefficient"/>, otherwise false.</returns>
        public bool Equals(ARKitBlendShapeCoefficient other)
        {
            return
                (blendShapeLocation == other.blendShapeLocation) &&
                coefficient.Equals(other.coefficient);
        }

        /// <summary>
        /// Tests for equality.
        /// </summary>
        /// <param name="obj">The `object` to compare against.</param>
        /// <returns>`True` if <paramref name="obj"/> is of type <see cref="ARKitBlendShapeCoefficient"/> and
        /// <see cref="Equals(ARKitBlendShapeCoefficient)"/> also returns `true`; otherwise `false`.</returns>
        public override bool Equals(object obj) => (obj is ARKitBlendShapeCoefficient other) && Equals(other);

        /// <summary>
        /// Generates a hash suitable for use with containers like `HashSet` and `Dictionary`.
        /// </summary>
        /// <returns>A hash code generated from this object's fields.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hash = ((int)m_BlendShapeLocation).GetHashCode();
                hash = hash * 486187739 + coefficient.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// Tests for equality. Same as <see cref="Equals(ARKitBlendShapeCoefficient)"/>.
        /// </summary>
        /// <param name="lhs">The left-hand side of the comparison.</param>
        /// <param name="rhs">The right-hand side of the comparison.</param>
        /// <returns>`True` if <paramref name="lhs"/> is equal to <paramref name="rhs"/>, otherwise `false`.</returns>
        public static bool operator==(ARKitBlendShapeCoefficient lhs, ARKitBlendShapeCoefficient rhs) => lhs.Equals(rhs);

        /// <summary>
        /// Tests for inequality. Same as `!`<see cref="Equals(ARKitBlendShapeCoefficient)"/>.
        /// </summary>
        /// <param name="lhs">The left-hand side of the comparison.</param>
        /// <param name="rhs">The right-hand side of the comparison.</param>
        /// <returns>`True` if <paramref name="lhs"/> is not equal to <paramref name="rhs"/>, otherwise `false`.</returns>
        public static bool operator!=(ARKitBlendShapeCoefficient lhs, ARKitBlendShapeCoefficient rhs) => !lhs.Equals(rhs);
    }
}
