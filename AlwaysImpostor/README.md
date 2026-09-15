# Always Impostor

A small host-only Among Us mod project for Android/Starlight.

## Goal

When you host a game, your player is always assigned the Impostor role. Everyone else can remain on an unmodded client when the lobby/mod protocol supports host-only behavior.

## Android target

- Among Us 2026.8.18 / v18
- Starlight 2.0.0
- Android

The current Starlight release notes explicitly list support for Among Us v18 / 2026.8.18. Starlight also provides host-only mod support.

## Status

This repository now contains the Android target and build scaffold. The actual role hook must be compiled against the Starlight/game assemblies for the exact Android build because those generated APIs are not distributed as ordinary .NET references.

The old PC BepInEx implementation is intentionally not used for Android.

## Install concept

1. Install the compatible Starlight version on the Android device.
2. Build/package this mod against the matching Starlight and Among Us game libraries.
3. Install the resulting Starlight mod package using the Starlight mod system.
4. Host a private/appropriate modded lobby.

## Versioning

If Among Us updates beyond 2026.8.18, wait for the corresponding Starlight compatibility update and retarget the generated game libraries before rebuilding.

Unofficial community project; not affiliated with Innersloth.
