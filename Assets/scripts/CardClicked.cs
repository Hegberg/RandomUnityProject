using UnityEngine;
using System.Collections;

public class CardClicked : MonoBehaviour {
    private int PlaceInList = -1;

    private string CloneRemove = "(Clone)";
    private string TempName;
    private string FixedName;

    public static bool InHand = false;

    // Use this for initialization
    void Start () {
        //Debug.Log("gameObject -> " + gameObject.name);
        TempName = gameObject.name;
        FixedName = TempName.Replace(CloneRemove, "");
        //Debug.Log("fixed name -> " + FixedName);
        for(int i = 0; i<CardManagerNoScroll.AllCards.Count; i++)
        {
            //Debug.Log("GameObject trying to find -> " + CardManagerNoScroll.AllCards[i].name);
            if (CardManagerNoScroll.AllCards[i].name == FixedName)
            {
                PlaceInList = i;
            }
        }
        //Debug.Log("Place in list after -> " + PlaceInList);
        //FeelsBadMan
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("Changed Page in other update -> " + DownArrowScript.ChangedPage);
        /*
        if (DownArrowScript.ChangedPage)
        {
            Debug.Log("Changed Page in other -> " + DownArrowScript.ChangedPage);
            //Debug.Log("changed page -> " + DownArrowScript.ChangedPage);
            //DownArrowScript.ChangedPage = false;
            RemoveFromScreen();
        }
        */
	}

    void OnMouseOver(){
        //If in Game, needs to be before deck creator, so doesn't check class that isn't alive yet

        if (Input.GetMouseButtonDown(0) && GameControl.InGame)
        {
            if (InHand)
            {

            }
            else
            {

            }
        }
        //If in Deck Creater
        else if (Input.GetMouseButtonDown(0) && CreateNewDeckScript.CreatingDeck)
        {
            if (DeckCardParentScript.DeckCreating.Count < 60)
            {
                if (DeckCardParentScript.DeckCreating.Count > 0)
                {
                    int TempFirstIndex = 0;
                    int TempLastIndex = 0;
                    TempFirstIndex = DeckCardParentScript.DeckCreating.IndexOf(PlaceInList);
                    //Debug.Log("TempFirstIndex -> " + TempFirstIndex);
                    TempLastIndex = TempFirstIndex;
                    TempLastIndex = DeckCardParentScript.DeckCreating.LastIndexOf(PlaceInList);
                    //Debug.Log("TempLastIndex -> " + TempLastIndex);
                    int temp = TempLastIndex - TempFirstIndex + 1;
                    //Debug.Log("Amounts of the same card already in deck -> " + temp);
                    //TempLastIndex - TempFirstIndex < 1   -> means 1 card already exists, 2 allowed
                    //TempLastIndex - TempFirstIndex < 2   -> means 2 cards already exist, 3 allowed, etc
                    if (TempLastIndex - TempFirstIndex < 3)
                    {
                        //Debug.Log("Card Clicked Number -> " + PlaceInList);
                        DeckCardParentScript.CardThatWasChanged = PlaceInList;
                        DeckCardParentScript.WasCardAdded = true;
                    }
                }
                else
                {
                    Debug.Log("Amounts of the same card already in deck -> 0");
                    DeckCardParentScript.CardThatWasChanged = PlaceInList;
                    DeckCardParentScript.WasCardAdded = true;
                }
            } else
            {
                Debug.Log("Deck is full -> " + DeckCardParentScript.DeckCreating.Count);
            }

        }
        
    }

    void RemoveFromScreen()
    {
        Destroy(gameObject);
    }

    public void SetPlaceInList(int TempInt) {
        PlaceInList = TempInt;
    }

}
