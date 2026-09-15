# Always Impostor — Android / Starlight

Target: Among Us Android, current supported Starlight platform.

## Current target

Starlight 2.0.0 supports Among Us v18 / 2026.8.18 (Judge Update). The mod should therefore target the Starlight Android environment rather than the old PC-only BepInEx setup.

## Mod behavior

- Host only.
- The host is guaranteed to receive the Impostor role each round.
- Other players do not need to install this mod.
- Non-host roles are left to normal Among Us role assignment.
- The implementation must use host authority rather than a local visual-only role change.

## Important Android note

The exact Android mod API and generated game-library signatures are version-specific. Do not copy the old BepInEx PC project into an Android build. This folder is the Android target specification for the mod and should be implemented as a Starlight-compatible mod.

## Current compatibility target

Among Us: 2026.8.18 / v18 / Android package version 7240.
Starlight: 2.0.0.

If Among Us releases a newer version, the Starlight/game library compatibility must be updated before rebuilding.

## Safety / multiplayer

Use this in private or appropriately modded lobbies. It is unofficial and is not affiliated with Innersloth.
