# ORBIT Quest App

This folder contains the initial Unity-side source layout. It is a source scaffold, not yet a complete Unity project.

## Suggested setup
1. Install a Unity LTS editor with Android Build Support.
2. Create a Unity 3D (URP optional) project named ORBIT.
3. Copy the `Assets/` folder from this directory into the Unity project.
4. Install and configure the Unity OpenXR and Meta XR packages using their current official documentation.
5. Add the scene bootstrap and a simple monitor prefab, then test in the editor before deploying to a headset.

Package versions and headset compatibility must be selected and tested against the actual target device. Do not assume every Quest model supports the same feature set.

## First prototype
- Create a world-space Canvas prefab for a monitor surface.
- Assign that prefab to `WorkspaceController.monitorPrefab`.
- Add `WorkspaceController` to a scene object.
- Call `AddMonitor()` to spawn a monitor panel.
- Replace placeholder positioning with XR controller/hand interaction in the next iteration.

## Current limitations
- No streaming client yet.
- No XR interaction bindings yet.
- No persistence or monitor rendering surface yet.
- No claim of local Linux virtualization.
