﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.Dynamic;
using Microsoft.Geospatial;

public static class ClientAPI
{
    public static string Prepare_AUTH(string login, string password)
    {
        dynamic obj = new ExpandoObject();
        obj.login = login;
        obj.pass = password;
        string message = JsonConvert.SerializeObject(obj);

        return message;
    }

    public static string Prepare_REGISTER(UserData ud)
    {
        return JsonUtility.ToJson(ud);
    }

    public static string Prepare_CHECK(string token)
    {
        dynamic obj = new ExpandoObject();
        obj.token = token;
        string message = JsonConvert.SerializeObject(obj);

        return message;
    }

    public static string Prepare_UPD(GeoBoundingBox bounds, string token)
    {
        dynamic obj = new ExpandoObject();
        obj.bounds = bounds.ToBase64();
        obj.token = token;
        string message = JsonConvert.SerializeObject(obj);

        return message;
    }
}
