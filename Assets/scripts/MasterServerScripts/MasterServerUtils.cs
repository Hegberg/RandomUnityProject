using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MasterServerUtils {

    public static string uniqueGameType = "_Unity_Master_Server_Hegberg.com_";

    public static bool useCustomConfiguration = true;
    public static string customConfigIP = "127.0.0.1";
    public static int customConfigPort = 23466;

    private static void ConfigureMasterServer()
    {
        if (useCustomConfiguration)
        {
            MasterServer.ipAddress = customConfigIP;
            MasterServer.port = customConfigPort;
        }
    }

    public static void RequestHostList()
    {
        ConfigureMasterServer();
        MasterServer.RequestHostList(uniqueGameType);
    }

    public static List<HostData> ListHosts()
    {
        ConfigureMasterServer();
        HostData[] hostData = MasterServer.PollHostList();
        MasterServer.ClearHostList();
        return hostData.ToList();
    }

    public static void RegisterWithMasterServer(string gameName, string comment)
    {
        ConfigureMasterServer();
        MasterServer.RegisterHost(uniqueGameType, gameName, comment);
    }

    public static void OnFailedToConnectToMasterServer(NetworkConnectionError info)
    {
        Debug.Log("Unable to connect to Master Server! -> " + info);
    }

}
