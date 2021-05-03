#if UNITY_IOS
using System;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEditor.iOS;
using UnityEngine.XR.ARKit;

namespace UnityEditor.XR.ARKit
{
    class BuildProcessor : IPreprocessBuildWithReport
    {
        static readonly OSVersion k_MinimumXcodeTargetVersion = new OSVersion(11, 0, 0);

        public void OnPreprocessBuild(BuildReport report)
        {
            if (report.summary.platform == BuildTarget.iOS)
            {
                EnsureMinimumXcodeVersion();
            }
        }

        void EnsureMinimumXcodeVersion()
        {
#if UNITY_EDITOR_OSX
            var xcodeIndex = Math.Max(0, XcodeApplications.GetPreferedXcodeIndex());
            var xcodeVersion = OSVersion.Parse(XcodeApplications.GetXcodeApplicationPublicName(xcodeIndex));
            if (xcodeVersion == new OSVersion(0))
                throw new BuildFailedException($"Could not determine which version of Xcode was selected in the Build Settings. Xcode app was computed as \"{XcodeApplications.GetXcodeApplicationPublicName(xcodeIndex)}\".");

            if (xcodeVersion < new OSVersion(11, 0, 0))
                throw new BuildFailedException($"The selected Xcode version: {xcodeVersion} is below the minimum Xcode required Xcode version for the Unity ARKit Face Tracking Plugin.  Please target at least Xcode version {k_MinimumXcodeTargetVersion}.");
#endif
        }

        public int callbackOrder => 0;
    }
}
#endif
