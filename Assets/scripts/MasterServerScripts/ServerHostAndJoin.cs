using UnityEngine;
using System.Collections;

public class ServerHostAndJoin : MonoBehaviour {

    public int playerCount = 2;
    public int serverPort = 23467;
    bool useNAT = false;

    public bool lanOnly = true;
    string log = "";
    public bool displayLog = true;
    MasterServerInterface  msInterface;

    public Vector2 position = new Vector2(0,0);
    public Vector2 logPosition = new Vector2(200,50);

    //Control the behaviour of the script with this
    HostOrJoin hostOrJoin = HostOrJoin.NotSet;

    public enum HostOrJoin
    {
        Host,
        Join,
        NotSet
    }

    void TakeAction(HostOrJoin choice)
    {
        hostOrJoin = choice;

        //start or join, not both
        if(hostOrJoin == HostOrJoin.Host)
        {
            StartServer();
        }

        if(hostOrJoin == HostOrJoin.Join)
        {
            //If we're joing, create a MasterServerInterface to provide us with the interface for selecting a server
            msInterface = this.gameObject.AddComponent<MasterServerInterface>();
            //Provide a call back for when a server is selected
            msInterface.OnServerSelected += HandleOnServerSelected;
        }
    }

    public void StartServer()
    {
        //Determine if we should use network addresss translation
        //Essentially YES if server is behind a router and NO if server has a public IP
        if(lanOnly == true)
        {
            useNAT = false;
        } else
        {
            useNAT = !Network.HavePublicAddress();
        }

        //Start a simple server and add it to the master server list.
        //This will allow other players to locate it
        NetworkConnectionError state = Network.InitializeServer (playerCount, serverPort, useNAT);
        if(state == NetworkConnectionError.NoError)
        {
            MasterServerUtils.RegisterWithMasterServer("Chris's game", "This is random comment");
        } else
        {
            Log("Server; Could not initialize server -> " + state);
        }
    }

    void HandleOnServerSelected(HostData selectedServer)
    {
        //when the connect button is pressed in the master server interface behaviour, this is called
        if (selectedServer != null)
        {
            //Join and hide the list interface
            JoinServer(selectedServer);
        }
    }

    public void JoinServer(HostData hostData)
    {
        //Join a server given some Hostdata, this data is provided by the master server
        Log("Client; Attempting to join server");
        Network.Connect(hostData);
    }

    void OnPlayerConnected(NetworkPlayer player)
    {
        //Fired in every monobehaviour when a player connects to our server
        Log("Server; Player (" + player.ipAddress + ") connected");
    }

    void OnServerInitialized()
    {
        //fired in every Monobehaviour when a server is started
        Log("Server; Server started");
        if(msInterface != null)
        {
            msInterface.enabled = true;
        }
    }

    void OnPlayerDisconnected(NetworkPlayer player)
    {
        //Fired in every MonoBehaviour when a player disconnects from our server
        Log("Server: Player (" + player.ipAddress + ") disconnected!");
    }

    void OnConnectedToServer()
    {
        //Fired in every MonoBehaviour when a player connects to a server
        Log("Client: Connected to server!");
        if (msInterface != null)
            msInterface.enabled = false;
    }

    void OnDisconnectedFromServer(NetworkDisconnection info)
    {
        //Fired in every MonoBehaviour when a player disconnects from a server
        Log("Client: Disconnected from server: " + info);
        if (msInterface != null)
            msInterface.enabled = true;
    }

    private void Log(string message)
    {
        //Some simple logging on screen so we don't have to worry about the debug console.
        log += "\n" + message;
    }



    void OnGUI()
    {
        if (hostOrJoin == HostOrJoin.NotSet)
        {
            if (GUI.Button(new Rect(position.x, position.y, 220, 40), "Start Server"))
            {
                TakeAction(HostOrJoin.Host);
            }
            if (GUI.Button(new Rect(position.x, position.y + 45, 220, 40), "Join Server"))
            {
                TakeAction(HostOrJoin.Join);
            }
        }

        //Some simple logging on screen so we don't have to worry about the debug console.
        if (displayLog)
            //GUI.TextArea(new Rect(logPosition.x, logPosition.y, 220, 300), log);
            GUI.TextArea(new Rect(250, logPosition.y, 220, 300), log);
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
