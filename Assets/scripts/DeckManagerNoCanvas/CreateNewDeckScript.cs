using UnityEngine;
using System.Collections;

public class CreateNewDeckScript : MonoBehaviour {

    public static bool CreatingDeck = false;
    public static bool BackHit = false;
    public static bool deckLoaded = false;

    public Sprite SaveDeckSprite;
    public Sprite CreateDeckSprite;

    public Transform DeleteButton;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	    if (BackHit)
        {
            RemoveDeleteButton();
            this.gameObject.GetComponent<SpriteRenderer>().sprite = CreateDeckSprite;
            //this.gameObject.GetComponent<Renderer>().enabled = true;
            BackHit = false;
            DeckCardParentScript.DeckAbandonedClearCards = true;
        }
        if(deckLoaded)
        {
            ShowDeleteButton();
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SaveDeckSprite;
            deckLoaded = false;
        }
	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && !CreatingDeck)
        {
            if (DeckParentScript.control.GetNumberOfDecks() < 10)
            {
                DeckParentScript.control.SetDeckClicked(-1);
                ShowDeleteButton();
                CreatingDeck = true;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = SaveDeckSprite;
                //this.gameObject.GetComponent<Renderer>().enabled = false;
                //Debug.Log("Create New Deck pressed");
            } else
            {
                Debug.Log("Already have 10 decks");
            }
        } else if (Input.GetMouseButtonDown(0) && CreatingDeck)
        {
            if (DeckCardParentScript.DeckCreating.Count >= 20) //DeckSize is 20 currently
            {
                RemoveDeleteButton();
                CreatingDeck = false;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = CreateDeckSprite;
                DeckCardParentScript.DeckSavedClearCards = true;
            } else
            {
                int temp = 20 - DeckCardParentScript.DeckCreating.Count;
                Debug.Log("Deck needs " + temp + " more cards");
            }
        }
    }

    
    void ShowDeleteButton()
    {
        Instantiate(DeleteButton, new Vector3(30f, -19, 0), Quaternion.identity);
        //Debug.Log("Button Showing -> " + TempCard.name);
    }

    void RemoveDeleteButton()
    {
        //Debug.Log("Button Not Showing -> ");
        DeleteDeckScript.control.DetroyDeleteButton();
    }
    
}
