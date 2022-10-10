using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void ToGame()
    {
        //SceneManager.LoadScene(1);
        Debug.Log("Ini ke masuk Game");
    }

    public void ToSettings()
    {
        //SceneManager.LoadScene(2);
        Debug.Log("Ini ke masuk Settings");
    }

    public void ToBook()
    {
        //SceneManager.LoadScene(3);
        Debug.Log("Ini ke masuk Book");
    }
}
