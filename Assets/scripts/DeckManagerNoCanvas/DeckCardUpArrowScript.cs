using UnityEngine;
using System.Collections;

public class DeckCardUpArrowScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && CreateNewDeckScript.CreatingDeck)
        {
            //Debug.Log("Card Clicked Number -> " + PlaceInList);
            if (DeckCardParentScript.CardsShowingLowerLimit > 0)
            {
                if (DeckCardParentScript.CardsShowingLowerLimit <= 5)
                {
                    DeckCardParentScript.CardsShowingUpperLimit = DeckCardParentScript.CardsShowingUpperLimit - DeckCardParentScript.CardsShowingLowerLimit;
                    DeckCardParentScript.CardsShowingLowerLimit = 0; //change lower limit after used in calculation above
                }
                else
                {
                    DeckCardParentScript.CardsShowingUpperLimit -= 5;
                    DeckCardParentScript.CardsShowingLowerLimit -= 5;
                }
                DeckCardParentScript.DeckLimitChanged = true;
            }
        }
    }
}
