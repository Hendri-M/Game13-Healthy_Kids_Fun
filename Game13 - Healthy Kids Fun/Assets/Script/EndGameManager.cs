using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndGameManager : MonoBehaviour
{

    [Header("Bintang")]
    [SerializeField] private GameObject[] bintang;

    [Header("Karakter")]
    [SerializeField] Image loadKarakter;
    [SerializeField] Sprite[] poseKarakter;

    [Header("Nilai Gizi")]
    [SerializeField] TMP_Text[] nilaiGizi;

    [Header("Text")]
    [SerializeField] TMP_Text endGame;

    int karakterTerpilih;
    
    float energi;
    float protein;
    float karbohidrat;
    float lemak;

    void Start()
    {
        energi = PlayerPrefs.GetFloat("Energi");
        protein = PlayerPrefs.GetFloat("Protein");
        karbohidrat = PlayerPrefs.GetFloat("Karbohidrat");
        lemak = PlayerPrefs.GetFloat("Lemak");

        endGame.text = "Kalori yang kamu dapatkan sebesar " + energi + " kkal";

        nilaiGizi[0].text = "" + energi;
        nilaiGizi[1].text = "" + protein;
        nilaiGizi[2].text = "" + karbohidrat;
        nilaiGizi[3].text = "" + lemak;


        if (energi > 1400 || energi == 1600)
        {
            bintang[0].gameObject.SetActive(true);

            if (karakterTerpilih == 0)
            {
                loadKarakter.sprite = poseKarakter[1];
            }

            if (karakterTerpilih == 1)
            {
                loadKarakter.sprite = poseKarakter[5];
            }
        }
        else if (energi >= 1000 || energi == 1400)
        {
            bintang[1].gameObject.SetActive(true);

            
            if (karakterTerpilih == 0)
            {
                loadKarakter.sprite = poseKarakter[3];
            }

            if (karakterTerpilih == 1)
            {
                loadKarakter.sprite = poseKarakter[7];
            }
        }
        else if (energi < 1000 || energi == 500)
        {
            bintang[2].gameObject.SetActive(true);

            
            if (karakterTerpilih == 0)
            {
                loadKarakter.sprite = poseKarakter[8];
            }

            if (karakterTerpilih == 1)
            {
                loadKarakter.sprite = poseKarakter[9];
            }
        }
        else
        {
            bintang[3].gameObject.SetActive(true);

            
            if (karakterTerpilih == 0)
            {
                loadKarakter.sprite = poseKarakter[8];
            }

            if (karakterTerpilih == 1)
            {
                loadKarakter.sprite = poseKarakter[9];
            }

        }
    }
}
