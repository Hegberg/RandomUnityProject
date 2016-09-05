using UnityEngine;
using System.Collections;

public class OnlyMinionsFilterSript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver()
    {
        //Debug.Log("All Minions was moused over");
        if (Input.GetMouseButtonDown(0))
        {
            ChangeFilterScript.FilterChoice = 1;
            ChangeFilterScript.FilterChanged = true;
        }
    }

    void RemoveFiltersFromScreen()
    {
        Destroy(gameObject);
    }
}
