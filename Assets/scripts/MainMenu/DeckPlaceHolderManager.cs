using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class DeckPlaceHolderManager : MonoBehaviour {

    public static List<UnityEngine.Object> AllPlaceHolders = new List<UnityEngine.Object>();

    public static bool Created = false;

    //Minions
    public Transform OneToOnePlaceHolder;
    public Transform TwoToTwoPlaceHolder;
    public Transform ThreeToThreePlaceHolder;
    public Transform FourToFourPlaceHolder;
    public Transform FiveToFivePlaceHolder;
    public Transform SixToSixPlaceHolder;
    public Transform SevenToSevenPlaceHolder;
    public Transform EightToEightPlaceHolder;
    public Transform NineToNinePlaceHolder;

    //Spells
    public Transform OneDamageSpellPlaceHolder;
    public Transform TwoDamageSpellPlaceHolder;
    public Transform ThreeDamageSpellPlaceHolder;
    public Transform FourDamageSpellPlaceHolder;
    public Transform FiveDamageSpellPlaceHolder;
    public Transform SixDamageSpellPlaceHolder;
    public Transform SevenDamageSpellPlaceHolder;
    public Transform EightDamageSpellPlaceHolder;
    public Transform NineDamageSpellPlaceHolder;

    // Use this for initialization
    void Start () {
        //Debug.Log("Created -> " + Created);
        if (!Created)
        {
            //Debug.Log("Size -> " + AllPlaceHolders.Count);
            Created = true;

            //Need this list to be in same order as CardManagerNoScroll cards are
            //Need place holder prefabs to be named whaterver original card is named + DeckPlaceHolder -> ex. OneDamageDeckPlaceHolder
            AllPlaceHolders.Add(OneToOnePlaceHolder);
            AllPlaceHolders.Add(OneDamageSpellPlaceHolder);
            AllPlaceHolders.Add(TwoToTwoPlaceHolder);
            AllPlaceHolders.Add(TwoDamageSpellPlaceHolder);
            AllPlaceHolders.Add(ThreeToThreePlaceHolder);
            AllPlaceHolders.Add(ThreeDamageSpellPlaceHolder);
            AllPlaceHolders.Add(FourToFourPlaceHolder);
            AllPlaceHolders.Add(FourDamageSpellPlaceHolder);
            AllPlaceHolders.Add(FiveToFivePlaceHolder);
            AllPlaceHolders.Add(FiveDamageSpellPlaceHolder);
            AllPlaceHolders.Add(SixToSixPlaceHolder);
            AllPlaceHolders.Add(SixDamageSpellPlaceHolder);
            AllPlaceHolders.Add(SevenToSevenPlaceHolder);
            AllPlaceHolders.Add(SevenDamageSpellPlaceHolder);
            AllPlaceHolders.Add(EightToEightPlaceHolder);
            AllPlaceHolders.Add(EightDamageSpellPlaceHolder);
            AllPlaceHolders.Add(NineToNinePlaceHolder);
            AllPlaceHolders.Add(NineDamageSpellPlaceHolder);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
