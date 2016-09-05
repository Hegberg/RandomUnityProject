using UnityEngine;
using System.Collections;

public class CardParentScript : MonoBehaviour {

    public static bool FilterChangeClearCards = false;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (DownArrowScript.ChangedPage)
        {
            DownArrowScript.ChangedPage = false;
            RemoveCards();
        }
        /*
        if (FilterChangeClearCards)
        {
            FilterChangeClearCards = false;
            RemoveCards();
            RemoveFilters();
            ShowCardsNoScroll.ReInstanceCards = true;
        }
        */
        if (FilterChangeClearCards)
        {
            FilterChangeClearCards = false;
            RemoveCards();
            ShowCardsNoScroll.ReInstanceCards = true;
        }
    }

    void RemoveCards()
    {
        BroadcastMessage("RemoveFromScreen");
    }

    /*
    void RemoveFilters()
    {
        BroadcastMessage("RemoveFiltersFromScreen");
    }
    */
}
