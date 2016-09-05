using UnityEngine;
using System.Collections;

// :
// ;

public class EndTurnScript : MonoBehaviour {

    public static bool Player1Turn = true;
    public static bool TurnEnded = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (TurnEnded)
        {
            TurnEnded = false;
        }
	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) & Player1Turn)
        {
            Player1Turn = false;
            TurnEnded = true;

        }
        else if (Input.GetMouseButtonDown(0) & !Player1Turn)
        {
            Player1Turn = true;
            TurnEnded = true;
        }
    }
}
