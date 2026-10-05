# ARcheology

ARcheology is an Augmented Reality (AR) project built with Unity that delivers an interactive, educational archaeology experience. Using AR Foundation, players detect a real-world surface, spawn a virtual scene on it, pick up artefacts, scan them to unlock their information and store them in virtual cabinets. It was built as part of the **AR development track at Instituto de Pesquisa Eldorado, at NexVisual**. The original creator of the project is **Victor Vasconcelos**; this repository is a mirror of the project Luan built during the track.

## Features

- **AR plane detection**: `ARPlaneManager` tracks real surfaces and a "start" UI appears once a plane reaches a configurable minimum area.
- **Scene spawning**: on start, the scene prefab is instantiated at the centre of the largest detected plane and its children scale up with a short animation.
- **Touch interaction**: a tap raycast (Input System touchscreen) picks up or drops artefacts; a held artefact follows the camera.
- **Scanner**: placing an artefact on the scanner locks it, plays a scanning animation for a configurable duration (3 s by default) and then unlocks it as "scanned".
- **Information panel**: once scanned, picking up an artefact shows a floating panel with its name and description, read from a `ScriptableObject` (`SOObjectInfo`).
- **Spots and cabinets**: artefacts that collide with a cabinet are snapped into its first free spot.
- **Billboard text**: informational text always faces the camera.

## Architecture

| Path | Description |
| --- | --- |
| `Assets/Script/` | Gameplay scripts (see below) |
| `Assets/ScriptableObjects/Objects/` | `SOObjectInfo` definition and the `CubeInfo` / `SphereInfo` assets |
| `Assets/Prefab/` | `Cube`, `Spot`, `Cabinet`, `Scanner` and `SceneTemplate` prefabs |
| `Assets/Scenes/` | `MainScene.unity` |
| `Assets/Models/`, `Assets/Material/`, `Assets/Animations/` | Scanner model, cabinet material and scanner animations (idle / running) |
| `Assets/MobileARTemplateAssets/` | Assets from Unity's Mobile AR template (UI prompts, shaders, tutorial, primitives) |
| `Assets/XR/`, `Assets/XRI/` | XR plug-in management, ARCore/ARKit settings and XR Interaction Toolkit settings |
| `Packages/`, `ProjectSettings/` | Package manifest and Unity project settings |

Main scripts in `Assets/Script/`:

- `InitialSetup.cs`: listens to plane updates, shows the start UI and starts the experience on the biggest plane.
- `StartExperience.cs`: instantiates the scene prefab and animates its children.
- `ObjectInteractor.cs` (implements `IInteractable`): pick up, drop, lock and scanned state of an artefact.
- `HoldingManager.cs`: singleton managing the currently held object.
- `ScannerController.cs`: scanning flow and animation.
- `CabinetController.cs` and `SpotController.cs`: storage logic.
- `ObjectInfoController.cs`: shows the artefact name and description (TextMesh Pro).
- `InputHandler.cs`: touch raycast helper.
- `Billboard.cs`: makes a transform face the main camera.

## Tech stack

![Unity](https://img.shields.io/badge/Unity-000000?style=for-the-badge&logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=csharp&logoColor=white)
![ARCore](https://img.shields.io/badge/ARCore-4285F4?style=for-the-badge&logo=google&logoColor=white)
![ARKit](https://img.shields.io/badge/ARKit-000000?style=for-the-badge&logo=apple&logoColor=white)

- Unity 2022.3.62f1 with the Universal Render Pipeline
- AR Foundation 5.2.0, ARCore XR Plugin 5.2.0, ARKit XR Plugin 5.2.0
- XR Interaction Toolkit 3.1.2 and Input System 1.14.2
- TextMesh Pro 3.0.9

## Running the project

Requirements: Unity 2022.3.62f1 (Android and/or iOS build support) and an AR-capable Android or iOS device. The project is configured for Android minimum SDK 30 and iOS 12.0.

1. Clone the repository: `git clone https://github.com/Luan-Aiezza/ARcheology.git`
2. Open the folder in Unity Hub with Unity 2022.3.62f1 and let the packages resolve.
3. Open `Assets/Scenes/MainScene.unity`.
4. In Build Settings, switch the platform to Android or iOS and enable the matching XR plug-in (ARCore or ARKit) in XR Plug-in Management if needed.
5. Connect the device, build and run, then point the camera at a flat surface and tap the start button when it appears.

## Screenshots

<img width="948" height="451" alt="ARcheology screenshot" src="https://github.com/user-attachments/assets/8b822dc7-7493-45b5-950e-6783931b9037" />

## Team

- **Victor Vasconcelos**: original creator
- [**Luan Gabriel Fernandes Aiezza**](https://github.com/Luan-Aiezza): mirror and README
