﻿using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using Mirror;

public static class Globals
{
    public static int IntervalInSeconds_UPD = 10;
    public static int PlayerInitialValue = 1000;
    public static int PlayerBaseIncome = 1;
    public static string ServerAddress = "localhost";
    public static ushort NetworkingPort = 7777;
    public static string SqliteConnectionString = "URI=file:" + Application.persistentDataPath + "/database.db";
    public static int SessionTimeoutInHours = 1;
    public static int NonPlayerVisibilityInSeconds = 20;

    public static LoaderScreen GetLoader()
    {
        return GameObject.Find("Canvas").transform.Find("Loading Overlay").GetComponent<LoaderScreen>();
    }

    public static Prompt GetPrompt()
    {
        return GameObject.Find("Canvas").transform.Find("Prompt Overlay").GetComponent<Prompt>();
    }

    public static StartupManager GetStartupManager()
    {
        return GameObject.Find("StartupManager").GetComponent<StartupManager>();
    }

    public static NetworkHandler GetNetworkManager()
    {
        return GameObject.Find("Networking").GetComponent<NetworkHandler>();
    }

    public static DatabaseConnector GetDatabaseConnector()
    {
        return GameObject.Find("DatabaseConnector").GetComponent<DatabaseConnector>();
    }

    public static GameObject GetMap()
    {
        return GameObject.Find("Gameplay Space/Map");
    }

    public static DebugMode GetDebugConsole()
    {
        return GameObject.Find("Canvas").transform.Find("DebugUI").GetComponent<DebugMode>();
    }

    public static InputHandler GetInput()
    {
        return Camera.main.GetComponent<InputHandler>();
    }

    public static ClientLogic GetClientLogic()
    {
        return GameObject.Find("Logic").GetComponent<ClientLogic>();

    }
}
