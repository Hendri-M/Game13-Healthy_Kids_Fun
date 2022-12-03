using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameManager : MonoBehaviour
{

    [Header("Bintang")]
    [SerializeField] private GameObject[] bintang;

    float energi;

    void Start()
    {
        energi = PlayerPrefs.GetFloat("Energi");

        if (energi == 1400 || energi == 1600)
            bintang[0].gameObject.SetActive(true);
        else if (energi == 1000 || energi == 1400)
            bintang[1].gameObject.SetActive(true);
        else if (energi < 1000 || energi == 500)
            bintang[2].gameObject.SetActive(true);
        else
            bintang[3].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
