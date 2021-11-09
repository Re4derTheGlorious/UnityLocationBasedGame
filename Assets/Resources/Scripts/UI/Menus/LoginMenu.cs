﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using System.Dynamic;
using Newtonsoft.Json;

public class LoginMenu : SubMenu
{
    public SubMenu ReturnButtonTarget;

    public void Button_Login()
    {
        //Load login form data
        String login = content.transform.Find("Login Field").GetComponent<TMP_InputField>().text;
        String password = content.transform.Find("Password Field").GetComponent<TMP_InputField>().text;

        //Get token
        Globals.IsHost = false;
        Globals.GetNetworkManager().StartNetworking();
        dynamic obj = new ExpandoObject();
        obj.login = login;
        obj.pass = password;
        string message = JsonConvert.SerializeObject(obj);
        Globals.GetNetworkManager().SendMessageToServer("AUTH", message);
    }

    public void Button_Return()
    {
        ReturnButtonTarget.Enter();
        gameObject.GetComponent<SubMenu>().Exit();
    }
}
