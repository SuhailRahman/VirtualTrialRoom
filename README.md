# Virtual Trial Room
An Augmented Reality based App where a user can "try-on" different apparels through iOS mobile devices, enabling a rich visual, realistic and an enjoyable experience.<br>
This application has 4 dresses which are *Balerina*, *Prom dress*, *Maxi dress* and *Full Sleeves t-shirt*. The User Interface consists of two buttons, where the users can change the apparels and colors of the apparels dynamically. The user can view all the different angles of the dress like the front view, back view and side view.

![Balerina Dress](https://github.com/SuhailRahman/VirtualTrialRoom/blob/master/Images/Balerina%20dress.png "Balerina Dress")
![Prom Dress](https://github.com/SuhailRahman/VirtualTrialRoom/blob/master/Images/Prom%20Dress.png "Prom Dress")

**NOTE: This app is compatible only with iOS devices such as Iphone XS and above(including latest iPad), with OS version of 11 and above.**

## Prerequisites
1. Unity Installed. If you haven't downloaded yet, click [here](https://unity3d.com/get-unity/download) to download.
2. XCODE installed. 
**NOTE: XCODE is compatible only with MAC OS**

## SetUp VirtualTrialRoom
Once the prerequisites are installed. You need to open this project in Unity. In the scene, click on 'HumanBodyTracker' gameobject. Check all the fields are not empty except for the `Clone_Temporary` field, but the size of `Clone_Temporary` should be equal to `Dress_Prefab_Material`.

## Customization 
If you want to add an extra dress, you will have to download this template fbx file and replace the mesh of the robot with the mesh of your dress. Then apply rigging and skinning. You can check out this [tutorial](https://youtu.be/cRlb9tncJok). You can read more about this by clicking [here](https://docs.unity3d.com/Manual/UsingHumanoidChars.html)<br>
Make the following changes:
1. Increase the size of `Clone_Temporary` and `Dress_Prefab_Material` by 1 inside the `HumanBodyTracker` gameobject 
2. Add `new Dictionary<TrackableId, HumanBoneController>(),` in line 38 of [`Assets/Script/HumanBodyTracker.cs`](https://github.com/SuhailRahman/VirtualTrialRoom/blob/master/Assets/Script/HumanBodyTracker.cs). To add different colors to the dress, increase the size of 'Dress_Colour_Material' field inside `HumanBodyTracker` gameobject, and different materials.<br>
**NOTE: Relace only the mesh not the bones. Blender3D is highly recommended to create a dress and tp perform rigging and skinning**

## Build App
This [tutorial](https://youtu.be/80-nE7ichvk) demonstrates how to build this app on iOS devices using unity. Click [here](https://youtu.be/80-nE7ichvk) to watch.

## Future Work
1. A new button can be added for trying on two different outfits together. For example, the user can try out a pant and shirt together.
2. Physics motions can be added to the apparels to enhance the user experience.

## Contribution
It's always good to contribute back to the society. If you have any new features or bug-fixes, please raise a PR.

## Troubleshooting
1. If the application doesn't work as expected, try the [second branch](https://github.com/SuhailRahman/VirtualTrialRoom/tree/original_w/0_changes).
2. Don't toggle the second button when the apparel is displaying **Balerina** dress.
3. IF you have any problems with the app, please create an issue. I'll get back to you asap.

## References:
1. https://youtu.be/cfKzUYH4i7A
2. https://github.com/Unity-Technologies/arfoundation-samples
3. https://www.blender.org/
4. https://unity3d.com/get-unity/download

***

## Project Status: Alpha
