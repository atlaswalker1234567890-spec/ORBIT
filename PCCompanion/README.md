# ORBIT PC Companion

Planned desktop-side service for connecting a user's computer to the Quest app.

## Initial responsibilities
- Pairing and authentication.
- User-approved display/window capture.
- Video/audio encoding and transport.
- Keyboard and mouse input relay.
- Connection health and diagnostics.

## Security requirements
- No unauthenticated remote-control listener.
- Explicit host approval and visible active-session state.
- Encrypted transport and revocable pairing credentials.
- Never log passwords, private keys, or session secrets.

No companion executable is implemented yet. The first milestone is a small proof of concept for one host display streamed to the Quest app.
