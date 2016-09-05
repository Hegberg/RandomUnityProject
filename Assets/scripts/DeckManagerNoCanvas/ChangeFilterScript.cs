using UnityEngine;
using System.Collections;

public class ChangeFilterScript : MonoBehaviour {

    public Transform CardParent;
    public Transform AllCardsFilter;
    public Transform OnlyMinionsFilter;
    public Transform OnlySpellsFilter;

    
    public static bool ChooseFilterClicked = false;
    public static int FilterChoice = -1;
    //-1 for none, 0 for all, 1 for minions, 2 for spells
    public static bool FilterChanged = false;
    public static bool ShowAgain = false;
    

    // Use this for initialization
    void Start () {
        //Instantiate(AllCardsFilter, new Vector3(-43, -17.1f, 0), Quaternion.identity);
        //Instantiate(OnlyMinionsFilter, new Vector3(-43, -19, 0), Quaternion.identity);
        //Instantiate(OnlySpellsFilter, new Vector3(-43, -20.9f, 0), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
        /*
        if (ShowAgain)
        {
            ShowAgain = false;
            //gameObject.layer = 2;
            gameObject.transform.Translate(new Vector3(0, 50, 0));
            ChooseFilterClicked = false;
        }
        */
    }

    void OnMouseOver()
    {
        /*
        if (Input.GetMouseButtonDown(0) && !ChooseFilterClicked)
        {
            ChooseFilterClicked = true;
            gameObject.transform.Translate(new Vector3(0,-50,0));
            Transform TempCard = (Transform)Instantiate(AllCardsFilter, new Vector3(-43, -17.1f, 0), Quaternion.identity);
            TempCard.transform.SetParent(CardParent.transform, false);
            Transform TempCardTwo = (Transform)Instantiate(OnlyMinionsFilter, new Vector3(-43, -19, 0), Quaternion.identity);
            TempCardTwo.transform.SetParent(CardParent.transform, false);
            Transform TempCardThree = (Transform)Instantiate(OnlySpellsFilter, new Vector3(-43, -20.9f, 0), Quaternion.identity);
            TempCardThree.transform.SetParent(CardParent.transform, false);
        }
        */
    }
}
