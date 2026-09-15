# Always Impostor — Among Us Host Mod

This repository now contains the **Always Impostor** mod project.

## What it does
- The lobby host is forced to be an **Impostor** every normal game round.
- The mod runs **only on the host**.
- Other players do **not** need to install the mod.
- It does not intentionally change the roles of the other players.
- The host role is re-checked during the round so the feature can recover if Among Us reassigns the role.

## Project

`AlwaysImpostor/AlwaysImpostorPlugin.cs` contains the actual mod logic. Current Among Us mod source demonstrates the same host-side `CoSetRole(RoleTypes.Impostor, ...)` pattern. fileciteturn7file0L2-L13

## Build on your PC

1. Install Among Us for PC/Steam.
2. Install the current BepInEx IL2CPP setup for your exact Among Us version.
3. Install Reactor if your chosen BepInEx/Reactor setup requires it.
4. Open `AlwaysImpostor/AlwaysImpostor.csproj`.
5. Set the `AMONG_US_DIR` environment variable to your Among Us installation directory.
6. Build Release with the .NET SDK expected by your current BepInEx/Reactor setup.
7. The project copies `AlwaysImpostor.dll` into `BepInEx/plugins/AlwaysImpostor/` automatically when it detects that folder.

Example Windows command:

```powershell
$env:AMONG_US_DIR="C:\Program Files (x86)\Steam\steamapps\common\Among Us"
dotnet build .\AlwaysImpostor\AlwaysImpostor.csproj -c Release
```

## Compatibility note

Among Us updates can change generated IL2CPP assemblies and method signatures. If `CoSetRole` or the generated assembly paths differ in your installed version, update the project references/role-assignment call to match that version. The gameplay idea remains the same.

## Unofficial

This is a community-made mod and is not affiliated with or endorsed by Innersloth.
