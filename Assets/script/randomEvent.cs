using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class randomEvent : MonoBehaviour
{
    public int Event;
    public GameObject text;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;


    public void ButtonClickEvent()
    {
        Event = Random.Range(1, 7);
        if (Event == 0)
        {
            text.SetActive(false);
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(false);
        }
        else if (Event == 1)
        {
            text.SetActive(true);
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(false);
        }
        else if (Event == 2)
        {
            text.SetActive(false);
            text1.SetActive(true);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(false);
        }
        else if (Event == 3)
        {
            text.SetActive(false);
            text1.SetActive(false);
            text2.SetActive(true);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(false);
        }
        else if (Event == 4)
        {
            text.SetActive(false);
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(true);
            text4.SetActive(false);
            text5.SetActive(false);
        }
        else if (Event == 5)
        {
            text.SetActive(false);
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(true);
            text5.SetActive(false);
        }
        else
        {
            text.SetActive(false);
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(true);
        }
    }
}
