using UnityEngine;
using System.Collections;

public class DeckCardDownArrowScript : MonoBehaviour {

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
            if (DeckCardParentScript.DeckCreating.Count <= DeckCardParentScript.CardsShowingUpperLimit) {
                //Do nothing
            }
            if (DeckCardParentScript.DeckCreating.Count > DeckCardParentScript.CardsShowingUpperLimit)
            {
                if(DeckCardParentScript.DeckCreating.Count <= DeckCardParentScript.CardsShowingUpperLimit + 5)
                {
                    //Lower limit change first since upper limit changes in it's calculation
                    DeckCardParentScript.CardsShowingLowerLimit = DeckCardParentScript.CardsShowingLowerLimit + (DeckCardParentScript.DeckCreating.Count - DeckCardParentScript.CardsShowingUpperLimit);
                    DeckCardParentScript.CardsShowingUpperLimit = DeckCardParentScript.CardsShowingUpperLimit + (DeckCardParentScript.DeckCreating.Count - DeckCardParentScript.CardsShowingUpperLimit);
                    
                } else
                {
                    DeckCardParentScript.CardsShowingUpperLimit += 5;
                    DeckCardParentScript.CardsShowingLowerLimit += 5;
                }
                DeckCardParentScript.DeckLimitChanged = true;
            }
        }
    }
}
