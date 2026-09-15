# Always Impostor — Among Us Host Mod

A host-only Among Us mod concept: when the local player is the host, the host is guaranteed to receive the Impostor role each round. Other players do not need the mod installed.

## Intended stack
- BepInEx 6 IL2CPP
- Reactor
- Among Us PC/Steam

## Important
This repository is a project scaffold. The exact role-assignment hook is isolated in `AlwaysImpostorPlugin.cs` because Among Us internal APIs can change between game versions. Build against the exact game/Reactor version you have installed and update that hook if the API has changed.

## Behavior
1. The plugin loads only for the local host.
2. At the start of a round it attempts to ensure the host is an Impostor.
3. It never installs a client-side requirement for other players.
4. It does not alter the roles of non-host players.

## Build
Open the project in Visual Studio/Rider with the .NET SDK required by your current BepInEx/Reactor template. Set the Among Us/BepInEx/Reactor assembly references in `AlwaysImpostor.csproj`, then build Release.

The generated DLL belongs in:
`Among Us/BepInEx/plugins/AlwaysImpostor/`

This is an unofficial community mod and is not affiliated with Innersloth.
