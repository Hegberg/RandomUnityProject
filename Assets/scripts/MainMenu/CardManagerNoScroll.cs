using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardManagerNoScroll : MonoBehaviour
{
    public static bool Created = false;

    public static List<UnityEngine.Object> AllCards = new List<UnityEngine.Object>();
    public static List<UnityEngine.Object> AllMinions = new List<UnityEngine.Object>();
    public static List<UnityEngine.Object> AllSpells = new List<UnityEngine.Object>();

    //Minions
    public Transform OneToOne;
    public Transform TwoToTwo;
    public Transform ThreeToThree;
    public Transform FourToFour;
    public Transform FiveToFive;
    public Transform SixToSix;
    public Transform SevenToSeven;
    public Transform EightToEight;
    public Transform NineToNine;
    
    //Spells
    public Transform OneDamageSpell;
    public Transform TwoDamageSpell;
    public Transform ThreeDamageSpell;
    public Transform FourDamageSpell;
    public Transform FiveDamageSpell;
    public Transform SixDamageSpell;
    public Transform SevenDamageSpell;
    public Transform EightDamageSpell;
    public Transform NineDamageSpell;

    // Use this for initialization
    void Start()
    {
        //Debug.Log("Created -> " + Created);
        if (!Created)
        {
            //Debug.Log("Size Basic Cards -> " + AllCards.Count);
            //Lets lists be only created once and not added to multiple times
            Created = true;

            //Need this list to be in same order as DeckPlaceHolderManager cards are
            AllCards.Add(OneToOne);
            AllCards.Add(OneDamageSpell);
            AllCards.Add(TwoToTwo);
            AllCards.Add(TwoDamageSpell);
            AllCards.Add(ThreeToThree);
            AllCards.Add(ThreeDamageSpell);
            AllCards.Add(FourToFour);
            AllCards.Add(FourDamageSpell);
            AllCards.Add(FiveToFive);
            AllCards.Add(FiveDamageSpell);
            AllCards.Add(SixToSix);
            AllCards.Add(SixDamageSpell);
            AllCards.Add(SevenToSeven);
            AllCards.Add(SevenDamageSpell);
            AllCards.Add(EightToEight);
            AllCards.Add(EightDamageSpell);
            AllCards.Add(NineToNine);
            AllCards.Add(NineDamageSpell);

            AllMinions.Add(OneToOne);
            AllMinions.Add(TwoToTwo);
            AllMinions.Add(ThreeToThree);
            AllMinions.Add(FourToFour);
            AllMinions.Add(FiveToFive);
            AllMinions.Add(SixToSix);
            AllMinions.Add(SevenToSeven);
            AllMinions.Add(EightToEight);
            AllMinions.Add(NineToNine);

            AllSpells.Add(OneDamageSpell);
            AllSpells.Add(TwoDamageSpell);
            AllSpells.Add(ThreeDamageSpell);
            AllSpells.Add(FourDamageSpell);
            AllSpells.Add(FiveDamageSpell);
            AllSpells.Add(SixDamageSpell);
            AllSpells.Add(SevenDamageSpell);
            AllSpells.Add(EightDamageSpell);
            AllSpells.Add(NineDamageSpell);
            
            /* early test for passing variable through the code
            for(int i = 0; i < AllCards.Count; i++)
            {
                Debug.Log("name -> " + AllCards[i].name);
            }
            */
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
