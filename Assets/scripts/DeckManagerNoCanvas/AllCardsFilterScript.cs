using UnityEngine;
using System.Collections;

public class AllCardsFilterScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnMouseOver()
    {
        //Debug.Log("All Cards was moused over");
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("All Cards was clicked");
            ChangeFilterScript.FilterChoice = 0;
            ChangeFilterScript.FilterChanged = true;
        }
    }

    void RemoveFiltersFromScreen()
    {
        Destroy(gameObject);
    }
}
