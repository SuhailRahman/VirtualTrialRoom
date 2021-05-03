---
uid: arkitfacetracking-manual
---
# About ARKit Face Tracking

This package provides face tracking support to augment the [ARKit XR Plugin](xref:arkit-manual).

## Installing ARKit Face Tracking

To install this package, follow the instructions in the [Package Manager documentation](https://docs.unity3d.com/Packages/com.unity.package-manager-ui@latest/index.html).

## Using ARKit Face Tracking

This package implements the [face tracking subsystem](xref:arsubsystems-face-subsystem) defined in the [AR Subsystems](xref:arsubsystems-manual) package. Refer to that package's documentation for instructions on how to use basic face tracking.

This package also provides additional, ARKit-specific face tracking functionality. ARKit provides a series of "blendshapes" to describe different features of a face. Each blendshape is modulated from 0..1. For example, there is a blendshape location describing how closed the mouth is.

## Front facing camera

Face tracking requires the use of the front-facing (selfie) camera. When the front-facing camera is active, other tracking subsystems (for example, plane tracking or image tracking) may not be available. Likewise, if the rear-facing camera is active, face tracking may not be available. Different iOS devices support different combinations of features. If you `Start` other, conflicting subsystems (subsystems that require the rear-facing camera), the ARKit package could decide to use the rear-facing camera instead. Therefore, to use face tracking on ARKit, you should `Stop` any other subsystems which might use the rear-facing camera. These include:

* [Plane tracking](xref:arsubsystems-plane-subsystem)
* [Image tracking](xref:arsubsystems-image-tracking-subsystem)
* [Object tracking](xref:arsubsystems-object-tracking-subsystem)

## Technical details

### Requirements

This version of ARKit Face Tracking is compatible with the following versions of the Unity Editor:

* 2019.4
* 2020.1
* 2020.2
* 2021.1

To use this package, you must have:

- An iOS device capable of performing face tracking. Such devices require either a front-facing TrueDepth camera or an A12 Bionic chip (or later). Devices include:
  - iPhone X
  - iPhone XS
  - iPhone XS Max
  - iPhone XR
  - iPhone 11
  - iPhone 12
  - iPad Pro (11-inch)
  - iPad Pro (12.9-inch, 3rd generation)
  - iPhone SE
- iOS 11.0 or later
- Xcode 11.0 or later

### Known limitations

None

### Package contents

This version of **ARKit Face Tracking** includes a static library which provides an implementation of the [XRFaceSubsystem](xref:arsubsystems-face-subsystem).
