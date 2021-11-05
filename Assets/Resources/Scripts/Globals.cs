﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public static class Globals
{
    public static string ServerAddress = "89.64.59.190";
    public static ushort NetworkingPort = 7777;
    public static bool IsHost = false;
    public static string SqliteConnectionString = "URI=file:" + Application.persistentDataPath + "/database.db";

    public static NetworkManager GetNetworkManager()
    {
        return GameObject.Find("Networking").GetComponent<NetworkHandler>();
    }

    public static DatabaseConnector GetDatabaseConnector()
    {
        return GameObject.Find("Networking").GetComponent<DatabaseConnector>();
    }

    public static GameObject GetMap()
    {
        return GameObject.Find("Gameplay Space/Map");
    }

    public static DebugMode GetDebugConsole()
    {
        return GameObject.Find("Canvas/DebugUI").GetComponent<DebugMode>();
    }

    public static InputHandler GetInput()
    {
        return Camera.main.GetComponent<InputHandler>();
    }
}
