using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class randomNumber : MonoBehaviour
{
    public int Number;
    public Text NumberText;

    public int RandomTotal;
    public void ButtonClick()
    {
        if(RandomTotal == 0)
        {
        Number = Random.Range(0, 11);
        }
        else if (RandomTotal == 1)
        {
            Number = Random.Range(10, 31);
        }
        else if (RandomTotal == 2)
        {
            Number = Random.Range(30, 61);
        }
        else
        {
            Number = Random.Range(60, 101);
        }
    }
    public void Button()
    {
        RandomTotal = 0;
    }
    public void Button1()
    {
        RandomTotal = 1;
    }
    public void Button2()
    {
        RandomTotal = 2;
    }
    public void Button3()
    {
        RandomTotal = 3;
    }

    private void Update()
    {
        NumberText.text = Number.ToString();
    }
}
