using UnityEngine;
using System.Collections;

public class DownArrowScript : MonoBehaviour {

    public static bool ChangedPage = false;
    public static bool ChangedPageDownClicked = false;

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
            //temp used fopr debug line if needed
            /*
            int temp = (ShowCardsNoScroll.CurrentPage + 1) * 8;
            Debug.Log("Current Page number cards -> " + temp);
            Debug.Log("All Minion card count -> " + CardManagerNoScroll.AllMinions.Count);
            */
            if (Input.GetMouseButtonDown(0) && ((((ShowCardsNoScroll.CurrentPage + 1)* 8)) < CardManagerNoScroll.AllCards.Count))

            {
                //Debug.Log("DownArrow Clicked -> ");
                ChangedPageDownClicked = true;
                ChangedPage = true;
                //Debug.Log("Changed Page Down -> " + ChangedPage);
            }
        }
        else if (ShowCardsNoScroll.CurrentFilter == 1)
        {
            //temp used fopr debug line if needed
            /*
            int temp = (ShowCardsNoScroll.CurrentPage + 1) * 8;
            Debug.Log("Current Page number cards -> " + temp);
            Debug.Log("All Minion card count -> " + CardManagerNoScroll.AllMinions.Count);
            */
            if (Input.GetMouseButtonDown(0) && ((((ShowCardsNoScroll.CurrentPage + 1) * 8)) < CardManagerNoScroll.AllMinions.Count))

            {
                //Debug.Log("DownArrow Clicked -> ");
                ChangedPageDownClicked = true;
                ChangedPage = true;
                //Debug.Log("Changed Page Down -> " + ChangedPage);
            }
        }
        if (ShowCardsNoScroll.CurrentFilter == 2)
        {
            //temp used fopr debug line if needed
            /*
            int temp = (ShowCardsNoScroll.CurrentPage + 1) * 8;
            Debug.Log("Current Page number cards -> " + temp);
            Debug.Log("All Minion card count -> " + CardManagerNoScroll.AllMinions.Count);
            */
            if (Input.GetMouseButtonDown(0) && ((((ShowCardsNoScroll.CurrentPage + 1) * 8)) < CardManagerNoScroll.AllSpells.Count))

            {
                //Debug.Log("DownArrow Clicked -> ");
                ChangedPageDownClicked = true;
                ChangedPage = true;
                //Debug.Log("Changed Page Down -> " + ChangedPage);
            }
        }
    }
}
