using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] Image imageLoading;

    private void Start()
    {
        StartCoroutine(loadingScreen());
    }

    IEnumerator loadingScreen()
    {
        imageLoading.fillAmount = 0;

        yield return new WaitForSeconds(2);

        var asyncLoad = SceneManager.LoadSceneAsync(SceneLoader.ProgressLoad);
        
        if(asyncLoad.isDone == false)
        {
            imageLoading.fillAmount = asyncLoad.progress;
            yield return null;
        }
    }
}
