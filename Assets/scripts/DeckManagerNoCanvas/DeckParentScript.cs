using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class DeckParentScript : MonoBehaviour {

    public static DeckParentScript control;
    private List<List<int>> playerDecks = new List<List<int>>();
    public static bool showDecks = true;
    private int deckClicked = -1;

    // Use this for initialization
    void Start()
    {
        //if control doesn't exist make this control, otherwise destroy it
        if (control == null)
        {
            control = this;
            Load();
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        if (!CreateNewDeckScript.CreatingDeck)
        {
            for (int i = 0; i < playerDecks.Count; i++)
            {
                if (GUI.Button(new Rect(Screen.width - (Screen.width / 6.2f), (0 + (Screen.height / 15)) + (i * 20), Screen.width/9.6f, Screen.height/27f), "Deck Number " + (i + 1)))
                {
                    //Debug.Log("Button Clicked -> " + i);
                    deckClicked = i;
                    DeckCardParentScript.deckLoaded = true;
                    CreateNewDeckScript.CreatingDeck = true;
                    CreateNewDeckScript.deckLoaded = true;
                }
            }
        }
        
        /*
        if (GUI.Button(new Rect(43, 19, 100, 40), "Deck Number " + (1)))
        {
            Debug.Log("Button Clicked -> ");
        }
        */
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerDecks.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerDecks.dat", FileMode.Open);
            playerDecks = (List<List<int>>)bf.Deserialize(file);
            //Debug.Log("Number of Decks " + playerDecks.Count);
            file.Close();
        }
    }

    public void Save()
    {
        if (File.Exists(Application.persistentDataPath + "/playerDecks.dat"))
        {
            //Debug.Log("Deck selected2 " + deckClicked);
            //Debug.Log("Deck chosen size2 -> " + playerDecks[deckClicked].Count);
            playerDecks.RemoveAt(deckClicked);
            playerDecks.Insert(deckClicked, DeckCardParentScript.DeckCreating);
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerDecks.dat", FileMode.Open);
            bf.Serialize(file, playerDecks);
            file.Close();
        } else
        {
            playerDecks.Add(DeckCardParentScript.DeckCreating);
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath + "/playerDecks.dat");
            bf.Serialize(file, playerDecks);
            file.Close();
        }
        Load();
    }

    public List<int> GetPlayerDeck()
    {
        //Debug.Log("Deck selected " + deckClicked);
        //Debug.Log("Deck chosen size -> " + playerDecks[deckClicked].Count);
        return playerDecks[deckClicked];
    }

    public void SetDeckClicked(int temp)
    {
        deckClicked = temp;
    }

    public int GetNumberOfDecks()
    {
        return playerDecks.Count;
    }
}
