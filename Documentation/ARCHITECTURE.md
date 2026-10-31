# ORBIT — Preliminary Architecture

This is a hypothesis to guide prototypes. Validate platform APIs, performance, licensing, and headset compatibility before committing to implementation details.

## High-level components

```text
                 +---------------------------+
                 |       ORBIT Quest App     |
                 |                           |
                 |  Spatial Workspace / UI   |
                 |  Monitors / Input         |
                 |  Environments / Themes    |
                 |  Connection Manager      |
                 +-------------+-------------+
                               |
                   authenticated transport
                               |
                 +-------------v-------------+
                 |     ORBIT PC Companion    |
                 |                           |
                 | Capture / Encode / Stream |
                 | Input Relay               |
                 | Host Status / Pairing     |
                 +-------------+-------------+
                               |
                       Host operating system
```

Other connection targets may include SSH servers, remote Linux machines, and third-party remote desktop services.

## Quest application

Candidate: Unity with OpenXR, subject to a small technical spike.

Suggested modules:
- **Core:** app lifecycle, settings, persistence, logging.
- **Workspace:** spatial layout, panels, windows, focus, snapping.
- **Displays:** virtual monitor surfaces and rendering.
- **Input:** hand, controller, keyboard, and mouse routing.
- **Environments:** room/world loading and lighting controls.
- **Customization:** furniture, devices, materials, and saved presets.
- **Connections:** pairing, session state, transport abstraction.
- **Linux:** terminal and remote/local Linux integration experiments.

Keep rendering and workspace state separate from individual connection providers so that local panels, streamed displays, and terminal windows can coexist.

## PC companion

Responsibilities:
- Explicit pairing and authentication.
- Capture selected displays or windows with user consent.
- Encode and transmit video/audio.
- Receive and route user input.
- Report host capabilities and connection quality.
- Provide a secure update and diagnostics path.

Do not expose an unauthenticated remote-control endpoint. Prefer encrypted transport, short-lived pairing codes or keys, explicit host approval, and clear session indicators.

## Linux strategy

Investigate three distinct paths:

1. **Remote Linux desktop:** run Linux on another computer/server and stream its graphical desktop. Most realistic route to a full Linux GUI.
2. **Local Linux userspace:** investigate a userspace/container-style environment on Quest's Android base. Validate filesystem, process, package, graphics, and input constraints.
3. **Full virtual machine:** research separately. Hardware acceleration, kernel access, memory, thermals, and Quest platform restrictions may make this impractical.

A terminal window alone is not equivalent to a complete Linux desktop. Define and test the desired filesystem, shell, package management, GUI, audio, graphics, and developer-tool requirements.

## Network and security

- Pair devices intentionally; do not silently discover and control hosts.
- Encrypt remote sessions.
- Store secrets using platform-appropriate secure storage.
- Keep SSH keys and passwords out of logs and crash reports.
- Make microphone, audio, screen capture, and input permissions visible.
- Provide disconnect and revoke controls.
- Document supported protocols and their security tradeoffs.

## Data model

Prefer versioned, portable configuration files for:
- Workspace layouts.
- Monitor/display settings.
- Environment selection and parameters.
- Furniture and device placements.
- Theme and lighting settings.
- Connection profiles (store secrets separately from exported configuration).

## Key technical risks

- Quest performance, thermals, and memory budgets.
- Text clarity and comfort at practical virtual monitor sizes.
- Reliable low-latency video streaming and input.
- Android/Quest restrictions on background services, filesystem access, and virtualization.
- Hand/controller/keyboard interaction design.
- Asset download size, memory use, and content moderation for user-created environments.

## First technical spikes

1. Render and manipulate two or three readable virtual screens.
2. Test keyboard and mouse input in a spatial workspace.
3. Stream one PC display to Quest and measure latency/quality.
4. Test an SSH terminal workflow.
5. Compare remote graphical Linux with a local Linux userspace experiment.
