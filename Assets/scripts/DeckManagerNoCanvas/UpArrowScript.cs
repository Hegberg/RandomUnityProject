using UnityEngine;
using System.Collections;

public class UpArrowScript : MonoBehaviour {

    
    public static bool ChangedPageUpClicked = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnMouseOver()
    {
        //Debug.Log("Changed Page mouse over -> " + ChangedPage);
        if (ShowCardsNoScroll.CurrentFilter == 0)
        {
            //Debug.Log("Current Page -> " + ShowCardsNoScroll.CurrentPage);
            //Debug.Log("All Minion card count -> " + CardManagerNoScroll.AllCards.Count);
            if (Input.GetMouseButtonDown(0) && (ShowCardsNoScroll.CurrentPage > 0))
            {
                //Debug.Log("Up Arrow Clicked on page  -> " + ShowCardsNoScroll.CurrentPage);
                ChangedPageUpClicked = true;
                DownArrowScript.ChangedPage = true;
                //Debug.Log("Changed Page Up -> " + DownArrowScript.ChangedPage);
            }
        }
        else if (ShowCardsNoScroll.CurrentFilter == 1)
        {
            //Debug.Log("Current Page -> " + ShowCardsNoScroll.CurrentPage);
            //Debug.Log("All Minion card count -> " + CardManagerNoScroll.AllMinions.Count);
            if (Input.GetMouseButtonDown(0) && (ShowCardsNoScroll.CurrentPage > 0))
            {
                //Debug.Log("Up Arrow Clicked on page  -> " + ShowCardsNoScroll.CurrentPage);
                ChangedPageUpClicked = true;
                DownArrowScript.ChangedPage = true;
                //Debug.Log("Changed Page up -> " + DownArrowScript.ChangedPage);
            }
        }
        else if (ShowCardsNoScroll.CurrentFilter == 2)
        {
            //Debug.Log("Current Page -> " + ShowCardsNoScroll.CurrentPage);
            //Debug.Log("All Minion card count -> " + CardManagerNoScroll.AllSpells.Count);
            if (Input.GetMouseButtonDown(0) && (ShowCardsNoScroll.CurrentPage > 0))
            {
                //Debug.Log("Up Arrow Clicked on page  -> " + ShowCardsNoScroll.CurrentPage);
                ChangedPageUpClicked = true;
                DownArrowScript.ChangedPage = true;
                //Debug.Log("Changed Page up -> " + DownArrowScript.ChangedPage);
            }
        }
    }
}
