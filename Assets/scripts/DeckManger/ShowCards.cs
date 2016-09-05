using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShowCards : MonoBehaviour {

    public static List<string> UnlockedCards = new List<string>();
    public Canvas CardCanvas;
    // Use this for initialization
    void Start () {
        ShowAllCards();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void ShowAllCards ()
    {
        
        for (int i = 0; i < CardManager.AllMinions.Count; i++) {
            Debug.Log("Card Added -> " + i);
            GameObject Temp = Instantiate(CardManager.AllMinions[i], new Vector3(0 + (i*5), 0, 0), Quaternion.identity) as GameObject;
            //dowesn't find the canvas
            Temp.transform.SetParent(CardCanvas.transform, false);
        }
    }
    
}
