using UnityEngine;
using System.Collections;

public class DeckPlaceHolderScript : MonoBehaviour {

    private string CloneRemove = "DeckPlaceHolder(Clone)";
    private string TempName;
    private string FixedName;

    private int PlaceInList;

    // Use this for initialization
    void Start () {
        
        TempName = gameObject.name;
        FixedName = TempName.Replace(CloneRemove, "");
        //Debug.Log("fixed name -> " + FixedName);
        for (int i = 0; i < CardManagerNoScroll.AllCards.Count; i++)
        {
            //Debug.Log("GameObject trying to find -> " + CardManagerNoScroll.AllCards[i].name);
            if (CardManagerNoScroll.AllCards[i].name == FixedName)
            {
                PlaceInList = i;
            }
        }
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DeckCardParentScript.CardThatWasChanged = PlaceInList;
            DeckCardParentScript.WasCardRemoved = true;
            //Debug.Log("Card Removed -> " + FixedName);
            //Destroy(this.gameObject); // not needed since destroyed in sorting of deck
        }
    }

    void RemoveFromScreen()
    {
        Destroy(gameObject);
    }


}
