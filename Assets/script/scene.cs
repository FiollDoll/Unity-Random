using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void randomizer()
    {
        SceneManager.LoadScene(1);
    }
    public void randomizer1()
    {
        SceneManager.LoadScene(2);
    }
}
