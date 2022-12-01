using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PilihBekalManager : MonoBehaviour
{
    [Header("Game Object")] 
    [SerializeField] UnityEngine.GameObject panelGizi;
    [SerializeField] TMP_Text[] nilaiGizi;

    float energi;
    float protein;
    float karbohidrat;

    void Start()
    {
        energi = PlayerPrefs.GetFloat("Energi");
        protein = PlayerPrefs.GetFloat("Protein");
        karbohidrat = PlayerPrefs.GetFloat("Karbohidrat");

        nilaiGizi[0].text = "" + energi;
        nilaiGizi[1].text = "" + protein;
        nilaiGizi[2].text = "" + karbohidrat;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pilihBekal1()
    {
        float energiTambah = 53.2f;
        float proteinTambah = 20.5f;
        float karbohidratTambah = 80f;

        nilaiGizi[0].text = "" + (energi + energiTambah);
        nilaiGizi[1].text = "" + (protein + proteinTambah);
        nilaiGizi[2].text = "" + (karbohidrat + karbohidratTambah);
    }




    public void loadStats()
    {
        energi = PlayerPrefs.GetFloat("Energi");
        protein = PlayerPrefs.GetFloat("Protein");
        karbohidrat = PlayerPrefs.GetFloat("Karbohidrat");
    }
}
