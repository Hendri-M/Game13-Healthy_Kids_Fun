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
    float lemak;

    float energiTotal;
    float proteinTotal;
    float karbohidratTotal;
    float lemakTotal;


    void Start()
    {
        energi = PlayerPrefs.GetFloat("Energi");
        protein = PlayerPrefs.GetFloat("Protein");
        karbohidrat = PlayerPrefs.GetFloat("Karbohidrat");
        lemak = PlayerPrefs.GetFloat("Lemak");

        nilaiGizi[0].text = "" + energi;
        nilaiGizi[1].text = "" + protein;
        nilaiGizi[2].text = "" + karbohidrat;
        nilaiGizi[3].text = "" + lemak;
        
    }

    public void pilihBekal1()
    {
        float energiTambah = 350.0f;
        float proteinTambah = 13.94f;
        float karbohidratTambah = 44.15f;
        float lemakTambah = 12.21f;

        energiTotal = energi + energiTambah;
        proteinTotal = protein + proteinTambah;
        karbohidratTotal = karbohidrat + karbohidratTambah;
        lemakTotal = lemak + lemakTambah;

        nilaiGizi[0].text = "" + energiTotal;
        nilaiGizi[1].text = "" + proteinTotal;
        nilaiGizi[2].text = "" + karbohidratTotal;
        nilaiGizi[3].text = "" + lemakTotal;

        saveNewSats();
        StartCoroutine(giziPanel());
    }

    public void pilihBekal2()
    {
        float energiTambah = 449.0f;
        float proteinTambah = 6.42f;
        float karbohidratTambah = 79.48f;
        float lemakTambah = 13.94f;

        energiTotal = energi + energiTambah;
        proteinTotal = protein + proteinTambah;
        karbohidratTotal = karbohidrat + karbohidratTambah;
        lemakTotal = lemak + lemakTambah;

        nilaiGizi[0].text = "" + energiTotal;
        nilaiGizi[1].text = "" + proteinTotal;
        nilaiGizi[2].text = "" + karbohidratTotal;
        nilaiGizi[3].text = "" + lemakTotal;

        saveNewSats();
        StartCoroutine(giziPanel());
    }

    public void pilihBekal3()
    {
        float energiTambah = 275.0f;
        float proteinTambah = 10.45f;
        float karbohidratTambah = 39.01f;
        float lemakTambah = 9.29f;

        energiTotal = energi + energiTambah;
        proteinTotal = protein + proteinTambah;
        karbohidratTotal = karbohidrat + karbohidratTambah;
        lemakTotal = lemak + lemakTambah;

        nilaiGizi[0].text = "" + energiTotal;
        nilaiGizi[1].text = "" + proteinTotal;
        nilaiGizi[2].text = "" + karbohidratTotal;
        nilaiGizi[3].text = "" + lemakTotal;

        saveNewSats();
        StartCoroutine(giziPanel());
    }

    public void pilihBekal4()
    {
        float energiTambah = 417.0f;
        float proteinTambah = 12.79f;
        float karbohidratTambah = 62.61f;
        float lemakTambah = 14.03f;

        energiTotal = energi + energiTambah;
        proteinTotal = protein + proteinTambah;
        karbohidratTotal = karbohidrat + karbohidratTambah;
        lemakTotal = lemak + lemakTambah;

        nilaiGizi[0].text = "" + energiTotal;
        nilaiGizi[1].text = "" + proteinTotal;
        nilaiGizi[2].text = "" + karbohidratTotal;
        nilaiGizi[3].text = "" + lemakTotal;

        saveNewSats();
        StartCoroutine(giziPanel());
    }

    IEnumerator giziPanel()
    {
        yield return new WaitForSeconds(0.5f);
        panelGizi.SetActive(true);
    }

    private void saveNewSats()
    {
        PlayerPrefs.SetFloat("Energi", energiTotal);
        PlayerPrefs.SetFloat("Protein", proteinTotal);
        PlayerPrefs.SetFloat("Karbohidrat", karbohidratTotal);
        PlayerPrefs.SetFloat("Lemak", lemakTotal);
    }
}
