using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CardMenuBackScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        //Debug.Log("Card Menu Back was moused over");
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Card Menu Back was pressed");

            if (!CreateNewDeckScript.CreatingDeck)
            {

                //Need to change to edit or open different scene, seems to work just commented out
                //SceneManager.UnloadScene("DeckManagerNoCanvas");

                SceneManager.LoadScene("MainMenu");
            } else
            {
                CreateNewDeckScript.CreatingDeck = false;
                CreateNewDeckScript.BackHit = true;
            }
        }
    }
}
