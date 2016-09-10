using UnityEngine;
using System.Collections;


public class DeleteDeckScript : MonoBehaviour
{

    public static DeleteDeckScript control;

    // Use this for initialization
    void Start()
    {
        //if control doesn't exist make this control, otherwise destroy it
        if (control == null)
        {
            control = this;
            MoveOffScreen();
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MoveOffScreen()
    {

    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DeckParentScript.control.Delete();
            CreateNewDeckScript.CreatingDeck = false;
            //DeckCardParentScript.DeckSavedClearCards = true;
            CreateNewDeckScript.BackHit = true;
            //DetroyDeleteButton();
        }
    }

    public void DetroyDeleteButton()
    {
        Destroy(this.gameObject);
    }
}
