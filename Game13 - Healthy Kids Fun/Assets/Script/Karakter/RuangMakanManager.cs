using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuangMakanManager : MonoBehaviour
{
    [SerializeField] GameObject loadKarakter;
    [SerializeField] GameObject prefabsKarakter;
    [SerializeField] Button nextButton;

    void Start()
    {
        Instantiate(prefabsKarakter, loadKarakter.transform);

        nextButton.interactable = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
