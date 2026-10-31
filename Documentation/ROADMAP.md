# ORBIT — Initial Roadmap

The roadmap is ordered by risk reduction and user value. Dates are intentionally omitted until scope and hardware targets are confirmed.

## Phase 0 — Define and de-risk
- [ ] Confirm target Quest headset(s) and minimum supported OS.
- [ ] Choose Unity/OpenXR or another validated app stack.
- [ ] Establish performance, comfort, and accessibility targets.
- [ ] Prototype text legibility and spatial input.
- [ ] Test Quest-to-PC streaming feasibility.
- [ ] Research Linux userspace and remote Linux options.

**Exit:** a documented technical direction supported by working prototypes.

## Phase 1 — Core spatial workspace
- [ ] Launch into a simple default workspace.
- [ ] Create, move, resize, and close virtual panels.
- [ ] Support saved workspace layouts.
- [ ] Add basic keyboard, mouse, and controller interaction.
- [ ] Add comfort and display readability settings.

**Exit:** a stable workspace that is useful even before advanced customization.

## Phase 2 — PC companion and streaming
- [ ] Build a minimal desktop companion.
- [ ] Implement secure device pairing.
- [ ] Stream a selected desktop or window.
- [ ] Relay keyboard and mouse input.
- [ ] Add connection quality and troubleshooting indicators.

**Exit:** reliable end-to-end use of a real computer inside ORBIT.

## Phase 3 — Remote tools and Linux
- [ ] Add SSH connection profiles and terminal UI.
- [ ] Add file transfer or remote file browsing where safe.
- [ ] Prototype remote graphical Linux desktop support.
- [ ] Evaluate local Linux userspace feasibility on target hardware.
- [ ] Document limitations before advertising local VM support.

**Exit:** a clearly defined, tested Linux workflow.

## Phase 4 — Environments and customization
- [ ] Add a small set of polished environments.
- [ ] Add monitor and workspace appearance controls.
- [ ] Add desks, chairs, and computer/peripheral models.
- [ ] Save and restore complete workspace presets.
- [ ] Profile environment rendering and asset memory use.

**Exit:** meaningful personalization without compromising performance.

## Phase 5 — Content ecosystem
- [ ] Define asset and environment package formats.
- [ ] Add import/export and validation.
- [ ] Establish licensing, safety, and moderation rules.
- [ ] Explore sharing and community-created content.

**Exit:** a safe, maintainable path for third-party content.

## Definition of done for every phase

- Tested on named target hardware.
- Performance and known limitations documented.
- No secrets committed to the repository.
- User-facing controls and failure states are understandable.
- Core workflows remain usable and comfortable.
