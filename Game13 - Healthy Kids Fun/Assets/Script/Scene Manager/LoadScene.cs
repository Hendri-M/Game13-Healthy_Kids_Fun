using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void ToGame(string name)
    {
        SceneLoader.sceneLoadProgress(name);
    }

    public void ToResume()
    {
        //SceneManager.LoadScene(1);
        Debug.Log("Ini ke masuk Resume Game");
    }

}
