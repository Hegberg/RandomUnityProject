﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Play was clicked on -> ");
            //GameControl.InGame = true;
            SceneManager.LoadScene("Lobby");
        }
    }

    void ConnectToServer()
    {

    }
}
