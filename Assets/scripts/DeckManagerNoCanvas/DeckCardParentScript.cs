using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class DeckCardParentScript : MonoBehaviour {

    public static List<int> DeckCreating = new List<int>();
    public static bool WasCardAdded = false;
    public static bool WasCardRemoved = false;
    public static int CardThatWasChanged = -1;
    public static bool DeckAbandonedClearCards = false;
    public static bool DeckSavedClearCards = false;
    public static bool deckLoaded = false;

    public static bool DeckLimitChanged = false;

    public Transform DeckCardParent;

    public static int CardsShowingUpperLimit = 18;
    public static int CardsShowingLowerLimit = 0;

    private int cardAdded;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (WasCardAdded)
        {
            CardAdded(CardThatWasChanged);
            WasCardAdded = false;
        }
        
        if (WasCardRemoved)
        {
            CardRemoved(CardThatWasChanged);
            WasCardRemoved = false;
        }
        
        if (DeckAbandonedClearCards)
        {
            DeckAbandonedClearCards = false;
            if (DeckCreating.Count > 0)
            {
                RemoveCards();
            }
            DeckCreating.Clear();
            ResetCardLimits();
            //need this or cards don't load correctly after hitting back out of a deck
            DeckParentScript.control.Load();
        }
        if (DeckSavedClearCards)
        {
            DeckSavedClearCards = false;
            SaveDeck();
            DeckCreating.Clear();
            RemoveCards();
            ResetCardLimits();
        }
        if (DeckLimitChanged)
        {
            SortCardsInDeck();
            DeckLimitChanged = false;
        }
        if (deckLoaded)
        {
            DeckCreating = DeckParentScript.control.GetPlayerDeck();
            deckLoaded = false;
            SortCardsInDeck();
        }
    }

    void ResetCardLimits()
    {
        CardsShowingUpperLimit = 18;
        CardsShowingLowerLimit = 0;
    }

    public void SaveDeck()
    {
        //need to save deck locally and display it
        DeckParentScript.control.Save();
    }

    public void CardAdded(int CardAddedToDeck)
    {
        if (DeckCreating.Count > 0)
        {
            RemoveCards();
        }
        DeckCreating.Add(CardAddedToDeck);
        SortCardsInDeck();
        int temp = DeckCreating.LastIndexOf(CardAddedToDeck);

        if (temp >= CardsShowingUpperLimit)
        {
            int limitChange = (temp - CardsShowingUpperLimit) + 1;
            //Debug.Log("Change in limit -> " + limitChange);
            CardsShowingLowerLimit = CardsShowingLowerLimit + limitChange;
            CardsShowingUpperLimit = CardsShowingUpperLimit + limitChange;
        }
        //need to remove cards before sorting again
        if (DeckCreating.Count > 0)
        {
            RemoveCards();
        }
        SortCardsInDeck();
    }

    /*
    bool CardLookingFor(int temp) {
        Debug.Log("Temp In Loop -> " + temp);
        Debug.Log("CardAdded -> " + cardAdded);
        if (temp == cardAdded)
        {
            return true;
        } else
        {
            return false;
        }
    }
    */
    
    public void CardRemoved(int CardRemovedFromDeck)
    {
        RemoveCards();
        DeckCreating.Remove(CardRemovedFromDeck);
        SortCardsInDeck();
    }
    

    public void SortCardsInDeck()
    {

        //RemoveCards(); switched to Card added and removed so could deal with exceptions where deck is empty
        DeckCreating.Sort();
        //Debug.Log("Deck size " + DeckCreating.Count);
        for (int i = CardsShowingLowerLimit; i<DeckCreating.Count; i++)
        {
            if (i < CardsShowingUpperLimit)
            {
                //Debug.Log("Deck Sorting -> " + DeckCreating[i]);
                Transform TempCard = (Transform)Instantiate(DeckPlaceHolderManager.AllPlaceHolders[DeckCreating[i]], new Vector3(32f, 20.5f - ((i-CardsShowingLowerLimit) * 2), 0), Quaternion.identity);
                TempCard.transform.SetParent(DeckCardParent.transform, false);
            }
        }
    }

    void RemoveCards()
    {
        BroadcastMessage("RemoveFromScreen");
    }
}
