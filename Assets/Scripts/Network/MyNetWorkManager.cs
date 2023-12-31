using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using System.Buffers.Text;

public class MyNetWorkManager : NetworkManager
{
    public override void OnClientConnect()
    {
        base.OnClientConnect();
        Debug.Log("I connected to a server");
    }

    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        base.OnServerAddPlayer(conn);
        Debug.Log($"There are now {numPlayers} players");
    }
}
