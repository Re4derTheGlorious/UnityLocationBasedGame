﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientSideHandler : MonoBehaviour
{
    void Start()
    {
        if (Globals.IsHost)
        {
            gameObject.SetActive(false);
        }
        else
        {
            Globals.GetDebugConsole().LogMessage("Running as a client");
        }
    }
}