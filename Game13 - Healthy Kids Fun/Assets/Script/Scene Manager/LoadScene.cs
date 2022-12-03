using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void toGame(string name)
    {
        SceneLoader.sceneLoadProgress(name);
    }

    public void booksGame(string name)
    {
        SceneLoader.sceneLoadProgress(name);
    }

    public void backMainMenu(string name)
    {
        SceneLoader.sceneLoadProgress(name);
    }
    public void quitGame()
    {
        Application.Quit();
    }

}
