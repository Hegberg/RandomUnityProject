using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShowCardsNoScroll : MonoBehaviour
{

    public static List<string> UnlockedCards = new List<string>();
    public static int CurrentPage = 0;

    public static int CurrentFilter = 0;
    //0 for none
    //1 for minions
    //2 for spells

    public Transform CardParent;
    public static bool ReInstanceCards = false;

    // Use this for initialization
    void Start()
    {
        ShowFirstCards();
    }

    // Update is called once per frame
    void Update()
    {
        if(DownArrowScript.ChangedPageDownClicked)
        {
            DownArrowScript.ChangedPageDownClicked = false;
            ChangePageDown();
        }
        if (UpArrowScript.ChangedPageUpClicked)
        {
            UpArrowScript.ChangedPageUpClicked = false;
            ChangePageUp();
        }
        if (ChangeFilterScript.FilterChanged)
        {
            ChangeFilter();
        }
        if (ReInstanceCards)
        {
            ShowFirstCards();
            ReInstanceCards = false;
        }
    }

    void ChangeFilter()
    {
        ChangeFilterScript.ShowAgain = true;
        ChangeFilterScript.FilterChanged = false;
        CurrentFilter = ChangeFilterScript.FilterChoice;
        ChangeFilterScript.FilterChoice = -1;
        CardParentScript.FilterChangeClearCards = true;
        ChangeFilterScript.ShowAgain = true;
    }

    void ShowFirstCards()
    {
        CurrentPage = 0;
        if (CurrentFilter == 0)
        {
            for (int i = 0; i < 8; i++)
            //for (int i = 0; i < CardManager.AllCards.Count; i++)
            {
                if (i < 4)
                {
                    //Debug.Log("Card Added -> " + i + 1);

                    //This works for setting parent
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllCards[i], new Vector3(-30 + (i * 15), 5, 0), Quaternion.identity);
                    //Debug.Log("Object -> " + TempCard.gameObject.name);
                    TempCard.transform.SetParent(CardParent.transform, false);
                    //Debug.Log("what -> " + TempCard.GetComponents<CardClicked>());

                    //temp.transform.parent = CardParent.transform;
                    //temp.transform.SetParent(GameObject.Find("CardParent").transform, false);
                }
                else
                {
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllCards[i], new Vector3(-30 + ((i - 4) * 15), -10, 0), Quaternion.identity);
                    TempCard.transform.SetParent(CardParent.transform, false);
                }
            }
        }
        if (CurrentFilter == 1)
        {
            for (int i = 0; i < 8; i++)
            //for (int i = 0; i < CardManager.AllMinions.Count; i++)
            {
                if (i < 4)
                {
                    //Debug.Log("Card Added -> " + i + 1);

                    //This works for setting parent
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllMinions[i], new Vector3(-30 + (i * 15), 5, 0), Quaternion.identity);
                    //Debug.Log("Object -> " + TempCard.gameObject.name);
                    TempCard.transform.SetParent(CardParent.transform, false);

                    //temp.transform.parent = CardParent.transform;
                    //temp.transform.SetParent(GameObject.Find("CardParent").transform, false);
                }
                else
                {
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllMinions[i], new Vector3(-30 + ((i - 4) * 15), -10, 0), Quaternion.identity);
                    TempCard.transform.SetParent(CardParent.transform, false);
                }
            }
        }
        if (CurrentFilter == 2)
        {
            for (int i = 0; i < 8; i++)
            //for (int i = 0; i < CardManager.AllSpells.Count; i++)
            {
                if (i < 4)
                {
                    //Debug.Log("Card Added -> " + i + 1);
                    //This works for setting parent
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllSpells[i], new Vector3(-30 + (i * 15), 5, 0), Quaternion.identity);
                    //Debug.Log("Object -> " + TempCard.gameObject.name);
                    TempCard.transform.SetParent(CardParent.transform, false);

                    //temp.transform.parent = CardParent.transform;
                    //temp.transform.SetParent(GameObject.Find("CardParent").transform, false);
                }
                else
                {
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllSpells[i], new Vector3(-30 + ((i - 4) * 15), -10, 0), Quaternion.identity);
                    TempCard.transform.SetParent(CardParent.transform, false);
                }
            }
        }
    }

    void ChangePageDown()
    {
        CurrentPage += 1;
        if (CurrentFilter == 0)
        {
            for (int i = 0; (i < 8) && (i < CardManagerNoScroll.AllCards.Count - (CurrentPage * 8)); i++)
            {
                if (i < 4)
                {
                    //Debug.Log("Card Added -> " + i + 1);

                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllCards[i + (CurrentPage * 8)], new Vector3(-30 + (i * 15), 5, 0), Quaternion.identity);
                    TempCard.transform.SetParent(CardParent.transform, false);
                }
                else
                {
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllCards[i + (CurrentPage * 8)], new Vector3(-30 + ((i - 4) * 15), -10, 0), Quaternion.identity);
                    TempCard.transform.SetParent(CardParent.transform, false);
                }
            }

        }
        else if (CurrentFilter == 1)
        {
            for (int i = 0; (i < 8) && (i < CardManagerNoScroll.AllMinions.Count - (CurrentPage * 8)); i++)
            {
                if (i < 4)
                {
                    //Debug.Log("Card Added -> " + i + 1);
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllMinions[i + (CurrentPage * 8)], new Vector3(-30 + (i * 15), 5, 0), Quaternion.identity);
                    TempCard.transform.SetParent(CardParent.transform, false);
                }
                else
                {
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllMinions[i + (CurrentPage * 8)], new Vector3(-30 + ((i - 4) * 15), -10, 0), Quaternion.identity);
                    TempCard.transform.SetParent(CardParent.transform, false);
                }
            }
        }
        else if (CurrentFilter == 2)
        {
            for (int i = 0; (i < 8) && (i < CardManagerNoScroll.AllSpells.Count - (CurrentPage * 8)); i++)
            {
                if (i < 4)
                {
                    //Debug.Log("Card Added -> " + i + 1);
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllSpells[i + (CurrentPage * 8)], new Vector3(-30 + (i * 15), 5, 0), Quaternion.identity);
                    TempCard.transform.SetParent(CardParent.transform, false);
                }
                else
                {
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllSpells[i + (CurrentPage * 8)], new Vector3(-30 + ((i - 4) * 15), -10, 0), Quaternion.identity);
                    TempCard.transform.SetParent(CardParent.transform, false);
                }
            }
        }
    }

    void ChangePageUp()
    {
        CurrentPage -= 1;
        if (CurrentFilter == 0)
        {
            for (int i = 0; (i < 8) && (i < CardManagerNoScroll.AllCards.Count - (CurrentPage * 8)); i++)
            {
                if (i < 4)
                {
                    //Debug.Log("Card Added -> " + i + 1);
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllCards[i + (CurrentPage * 8)], new Vector3(-30 + (i * 15), 5, 0), Quaternion.identity);
                    TempCard.transform.SetParent(CardParent.transform, false);
                }
                else
                {
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllCards[i + (CurrentPage * 8)], new Vector3(-30 + ((i - 4) * 15), -10, 0), Quaternion.identity);
                    TempCard.transform.SetParent(CardParent.transform, false);
                }
            }
        }
        else if (CurrentFilter == 1)
        {
            for (int i = 0; (i < 8) && (i < CardManagerNoScroll.AllMinions.Count - (CurrentPage * 8)); i++)
            {
                if (i < 4)
                {
                    //Debug.Log("Card Added -> " + i + 1);
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllMinions[i + (CurrentPage * 8)], new Vector3(-30 + (i * 15), 5, 0), Quaternion.identity);
                    TempCard.transform.SetParent(CardParent.transform, false);
                }
                else
                {
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllMinions[i + (CurrentPage * 8)], new Vector3(-30 + ((i - 4) * 15), -10, 0), Quaternion.identity);
                    TempCard.transform.SetParent(CardParent.transform, false);
                }
            }
        }
        else if (CurrentFilter == 2)
        {
            for (int i = 0; (i < 8) && (i < CardManagerNoScroll.AllCards.Count - (CurrentPage * 8)); i++)
            {
                if (i < 4)
                {
                    //Debug.Log("Card Added -> " + i + 1);
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllCards[i + (CurrentPage * 8)], new Vector3(-30 + (i * 15), 5, 0), Quaternion.identity);
                    TempCard.transform.SetParent(CardParent.transform, false);
                }
                else
                {
                    Transform TempCard = (Transform)Instantiate(CardManagerNoScroll.AllCards[i + (CurrentPage * 8)], new Vector3(-30 + ((i - 4) * 15), -10, 0), Quaternion.identity);
                    TempCard.transform.SetParent(CardParent.transform, false);
                }
            }
        }
    }
}
    