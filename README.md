# ORBIT

**Your computer. Your operating system. Your workspace. Your universe.**

ORBIT is an ambitious mixed-reality computing workspace for Meta Quest. It aims to bring together remote desktops, virtual monitors, Linux development workflows, customizable virtual hardware, and immersive environments in one configurable space.

> ORBIT is an early-stage project. The documents describe goals and proposed architecture, not features that are already implemented.

## Vision

Build a place where people can work, create, code, play, and explore without being locked into one desktop layout or one physical environment.

Possible experiences include:
- Multiple floating or curved virtual monitors with adjustable size, resolution, and placement.
- Connecting to a physical computer for desktop streaming and remote workflows.
- SSH access and Linux development tools, with a path toward a full graphical Linux workspace.
- Customizable desks, chairs, computers, peripherals, lighting, and virtual room layouts.
- Environments ranging from a quiet studio to a rainforest, the Moon, or an underwater workspace.
- User-created and shareable themes, environments, and workspace configurations.

## Project principles

1. **User control:** customization should be deep, optional, and reversible.
2. **Modularity:** environments, devices, connection methods, and tools should be separable components.
3. **Performance first:** maintain comfort, responsiveness, and stable frame rates on target headsets.
4. **Honest capability boundaries:** distinguish local Quest features from features requiring a companion PC or remote host.
5. **Privacy and security:** make network connections explicit; protect credentials and remote sessions.

## Proposed repository layout

- `QuestApp/` — Quest application and mixed-reality workspace.
- `PCCompanion/` — desktop-side streaming and connection service.
- `Documentation/` — product vision, architecture, roadmap, and technical decisions.

## Getting started

There is no runnable application yet. Start with the documentation:
- [Vision](Documentation/VISION.md)
- [Architecture](Documentation/ARCHITECTURE.md)
- [Roadmap](Documentation/ROADMAP.md)

## Early technical direction

Unity with OpenXR is a candidate for the Quest experience. A separate PC companion can handle desktop capture and streaming. Linux support should be validated experimentally: a Linux userspace, a remote Linux host, and a full virtual machine are different approaches with different performance and platform constraints.

No specific headset compatibility or Linux virtualization capability is claimed until tested on actual hardware.

## Status

**Planning / prototype stage.** The first milestone is a comfortable, reliable multi-window workspace—not the entire feature universe at once.
