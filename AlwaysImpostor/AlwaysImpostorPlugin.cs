using BepInEx;
using AmongUs.GameOptions;
using UnityEngine;

namespace AlwaysImpostor;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public sealed class AlwaysImpostorPlugin : BaseUnityPlugin
{
    public const string PluginGuid = "ohzach67.alwaysimpostor";
    public const string PluginName = "Always Impostor";
    public const string PluginVersion = "1.0.0";

    private float _nextCheck;
    private bool _assignedThisRound;

    private void Update()
    {
        if (Time.time < _nextCheck)
            return;

        _nextCheck = Time.time + 0.5f;

        try
        {
            var client = AmongUsClient.Instance;
            var player = PlayerControl.LocalPlayer;

            // Host-only: clients joining the lobby do not need this plugin.
            if (client == null || !client.AmHost || player == null)
                return;

            // ShipStatus exists while a normal game round is active.
            if (ShipStatus.Instance == null)
            {
                _assignedThisRound = false;
                return;
            }

            if (player.Data == null || player.Data.IsDead)
                return;

            if (_assignedThisRound && player.Data.Role != null &&
                player.Data.Role.Role == RoleTypes.Impostor)
                return;

            ForceHostImpostor(player);
        }
        catch (Exception ex)
        {
            Logger.LogError($"Always Impostor failed: {ex}");
        }
    }

    private void ForceHostImpostor(PlayerControl player)
    {
        if (player.Data?.Role?.Role == RoleTypes.Impostor)
        {
            _assignedThisRound = true;
            return;
        }

        // CoSetRole is the host-authoritative role assignment coroutine used by
        // current Among Us mod projects. The second argument allows the role
        // change to override the player's existing role.
        player.StartCoroutine(player.CoSetRole(RoleTypes.Impostor, true));
        _assignedThisRound = true;
        Logger.LogInfo("Host forced to Impostor.");
    }
}
