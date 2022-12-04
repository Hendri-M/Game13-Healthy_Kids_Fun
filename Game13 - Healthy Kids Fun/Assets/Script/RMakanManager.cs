using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RMakanManager : MonoBehaviour
{
    [Header("Button")]
    [SerializeField] Button[] choosenFoods;

    [Header("Image")]
    [SerializeField] Image loadKarakter;
    [SerializeField] Sprite[] poseKarakter;
    [SerializeField] Image imageWarning;

    [Header("Nilai Gizi")]
    [SerializeField] TMP_Text[] statusGizi;

    [Header("GameObject")]
    [SerializeField] GameObject panelGizi;
    [SerializeField] GameObject panelWarning;

    int karakterTerpilih;

    float energi;
    float protein;
    float karbohidrat;
    float lemak;

    // Start is called before the first frame update
    void Start()
    {
        karakterTerpilih = PlayerPrefs.GetInt("Karakter");

        if (karakterTerpilih == 0)
        {
            loadKarakter.sprite = poseKarakter[0];
        }

        if (karakterTerpilih == 1)
        {
            loadKarakter.sprite = poseKarakter[4];
        }

        panelGizi.SetActive(false);
        panelWarning.SetActive(false);
        
    }

    public void menuMakanan1()
    {
        Debug.Log("Makanan1");
        energi = 474.0f;
        protein = 15.24f;
        karbohidrat = 81.84f;
        lemak = 10.59f;

        statusGizi[0].text = "" + energi;
        statusGizi[1].text = "" + protein;
        statusGizi[2].text = "" + karbohidrat;
        statusGizi[3].text = "" + lemak;
        
        poseSenyum();
        saveStats();

        StartCoroutine(giziPanel());
        StartCoroutine(changePose());
    }

    public void menuMakanan2()
    {
        Debug.Log("Makanan2");
        energi = 404.0f;
        protein = 10.16f;
        karbohidrat = 87.8f;
        lemak = 2.02f;

        statusGizi[0].text = "" + energi;
        statusGizi[1].text = "" + protein;
        statusGizi[2].text = "" + karbohidrat;
        statusGizi[3].text = "" + lemak;

        poseSenyum();
        saveStats();

        StartCoroutine(giziPanel());
        StartCoroutine(changePose());
    }

    public void menuMakanan3()
    {
        Debug.Log("Makanan3");
        energi = 332.0f;
        protein = 6.6f;
        karbohidrat = 47.41f;
        lemak = 15.31f;

        statusGizi[0].text = "" + energi;
        statusGizi[1].text = "" + protein;
        statusGizi[2].text = "" + karbohidrat;
        statusGizi[3].text = "" + lemak;

        poseSenyum();
        saveStats();

        StartCoroutine(giziPanel());
        StartCoroutine(changePose());
    }

    public void menuMakanan4()
    {
        Debug.Log("Makanan4");
        energi = 290.0f;
        protein = 10.34f;
        karbohidrat = 42.07f;
        lemak = 10.09f;

        statusGizi[0].text = "" + energi;
        statusGizi[1].text = "" + protein;
        statusGizi[2].text = "" + karbohidrat;
        statusGizi[3].text = "" + lemak;

        poseSenyum();
        saveStats();

        StartCoroutine(giziPanel());
        StartCoroutine(changePose());
    }

    public void menuMakanan5()
    {
        Debug.Log("Makanan5");
        energi = 497.0f;
        protein = 18.68f;
        karbohidrat = 71.0f;
        lemak = 15.25f;

        statusGizi[0].text = "" + energi;
        statusGizi[1].text = "" + protein;
        statusGizi[2].text = "" + karbohidrat;
        statusGizi[3].text = "" + lemak;

        poseSenyum();
        saveStats();

        StartCoroutine(giziPanel());
        StartCoroutine(changePose());
    }

    public void piringKosong()
    {
        poseTerkejut();

        StartCoroutine(warningPanel());
        StartCoroutine(changePose());
    }

    IEnumerator giziPanel()
    {
        yield return new WaitForSeconds(0.5f);
        panelGizi.SetActive(true);
    }

    IEnumerator warningPanel()
    {
        yield return new WaitForSeconds(0.35f);

        poseSedih();
        panelWarning.SetActive(true);
    }

    IEnumerator changePose()
    {
        yield return new WaitForSeconds(1);
        poseNormal();
    }

    private void poseSedih()
    {
        if (karakterTerpilih == 0)
        {
            imageWarning.sprite = poseKarakter[8];
        }

        if (karakterTerpilih == 1)
        {
            imageWarning.sprite = poseKarakter[9];
        }
    }

    private void poseNormal()
    {
        if (karakterTerpilih == 0)
        {
            loadKarakter.sprite = poseKarakter[0];
        }

        if (karakterTerpilih == 1)
        {
            loadKarakter.sprite = poseKarakter[4];
        }
    }

    private void poseSenyum()
    {
        if (karakterTerpilih == 0)
        {
            loadKarakter.sprite = poseKarakter[1];
        }

        if (karakterTerpilih == 1)
        {
            loadKarakter.sprite = poseKarakter[5];
        }
    }

    private void poseTerkejut()
    {
        if (karakterTerpilih == 0)
        {
            loadKarakter.sprite = poseKarakter[3];
        }

        if (karakterTerpilih == 1)
        {
            loadKarakter.sprite = poseKarakter[7];
        }
    }

    private void saveStats()
    {
        PlayerPrefs.SetFloat("Energi", energi);
        PlayerPrefs.SetFloat("Protein", protein);
        PlayerPrefs.SetFloat("Karbohidrat", karbohidrat);
        PlayerPrefs.SetFloat("Lemak", lemak);
    }

}
