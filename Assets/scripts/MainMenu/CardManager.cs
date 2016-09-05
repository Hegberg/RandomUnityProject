using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardManager : MonoBehaviour {

    public static List<UnityEngine.Object> AllMinions = new List<UnityEngine.Object>();

    public Transform OneToOne;
    public Transform TwoToTwo;
    public Transform ThreeToThree;
    public Transform FourToFour;
    public Transform FiveToFive;
    public Transform SixToSix;
    public Transform SevenToSeven;
    public Transform EightToEight;
    public Transform NineToNine;

    // Use this for initialization
    void Start () {

        AllMinions.Add(OneToOne);
        AllMinions.Add(TwoToTwo);
        AllMinions.Add(ThreeToThree);
        AllMinions.Add(FourToFour);
        AllMinions.Add(FiveToFive);
        AllMinions.Add(SixToSix);
        AllMinions.Add(SevenToSeven);
        AllMinions.Add(EightToEight);
        AllMinions.Add(NineToNine);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
