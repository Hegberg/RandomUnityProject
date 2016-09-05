using UnityEngine;
using System.Collections;

public class OnlySpellsFilterScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver()
    {
        //Debug.Log("All Spells was moused over");
        if (Input.GetMouseButtonDown(0))
        {
            ChangeFilterScript.FilterChoice = 2;
            ChangeFilterScript.FilterChanged = true;
        }
    }

    void RemoveFiltersFromScreen()
    {
        Destroy(gameObject);
    }
}
