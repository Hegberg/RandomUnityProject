using UnityEngine;
using System.Collections;

public class MasterServerTestServer : MonoBehaviour {

    int playerCount = 2;
    int serverPort =23467;
    bool useNAT = false;
    bool serverStarted = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Space) && !serverStarted)
        {
            StartServer();
        }
	}

    public void StartServer()
    {
        NetworkConnectionError state = Network.InitializeServer(playerCount, serverPort, useNAT);
        if(state == NetworkConnectionError.NoError)
        {
            MasterServerUtils.RegisterWithMasterServer("Testing test game", "Heres an obligatory comment");
            serverStarted = true;
        } else
        {
            Debug.Log("server failed to initalize -> " + state);
        }
    }
}
