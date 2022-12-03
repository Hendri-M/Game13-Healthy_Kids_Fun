using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    [Header("Karakter Guru")]
    [SerializeField] private Image guru;
    [SerializeField] private Sprite[] poseGuru;

    [Header("Button")]
    [SerializeField] private Button[] soalBtn;

    [Header("Panel dan Nilai Gizi")]
    [SerializeField] private GameObject panelGizi;
    [SerializeField] private TMP_Text[] nilaiGizi;

    [Header("Quiz")]
    [SerializeField] private List<GameObject> soalBank;
    [SerializeField] private List<GameObject> soalMuncul;

    int nomorSoal = 0;
    int random;

    float energi;
    float protein;
    float karbohidrat;
    float lemak;

    void Start()
    {
        energi = PlayerPrefs.GetFloat("Energi", energi);
        protein = PlayerPrefs.GetFloat("Protein", protein);
        karbohidrat = PlayerPrefs.GetFloat("Karbohidrat", karbohidrat);
        lemak = PlayerPrefs.GetFloat("Lemak", lemak);

        nilaiGizi[0].text = "" + energi;
        nilaiGizi[1].text = "" + protein;
        nilaiGizi[2].text = "" + karbohidrat;
        nilaiGizi[3].text = "" + lemak;

        guru.sprite = poseGuru[0];
        ambilSoal();
    }

    private void ambilSoal()
    {
        for (int i = 0; i < 10; i++)
        {
            random = Random.Range(0, soalBank.Count);
            soalMuncul.Add(soalBank[random]);
            soalBank.Remove(soalBank[random]);
        }

        soalMuncul[nomorSoal].gameObject.SetActive(true);
        soalBtn = soalMuncul[nomorSoal].GetComponentsInChildren<Button>();
    }

    private void soalSelanjutnya()
    {
        soalMuncul[nomorSoal].gameObject.SetActive(false);
        nomorSoal++;

        if (nomorSoal >= soalMuncul.Count)
        {
            StartCoroutine(giziPanel());
        }
        else
        {
            soalMuncul[nomorSoal].gameObject.SetActive(true);
            soalBtn = soalMuncul[nomorSoal].GetComponentsInChildren<Button>();
        }
    }

    public void jawabBenar()
    {
        energi += 10.0f;
        protein += 10.0f;
        karbohidrat += 10.0f;
        lemak += 10.0f;

        nilaiGizi[0].text = "" + energi;
        nilaiGizi[1].text = "" + protein;
        nilaiGizi[2].text = "" + karbohidrat;
        nilaiGizi[3].text = "" + lemak;

        saveNewSats();
        poseGuruBenar();
        StartCoroutine(delayQuiz());

        soalBtn[0].interactable = false;
        soalBtn[1].interactable = false;
    }
    public void jawabSalah()
    {
        saveNewSats();
        poseGuruSalah();
        StartCoroutine(delayQuiz());

        soalBtn[0].interactable = false;
        soalBtn[1].interactable = false;
    }

    private void poseGuruBenar()
    {
        guru.sprite = poseGuru[1];
    }

    private void poseGuruSalah()
    {
        guru.sprite = poseGuru[2];
    }

    IEnumerator delayQuiz()
    {
        yield return new WaitForSeconds(0.75f);
        
        guru.sprite = poseGuru[0];
        soalSelanjutnya();
    }

    IEnumerator giziPanel()
    {
        yield return new WaitForSeconds(0.1f);
        panelGizi.SetActive(true);
    }

    private void saveNewSats()
    {
        PlayerPrefs.SetFloat("Energi", energi);
        PlayerPrefs.SetFloat("Protein", protein);
        PlayerPrefs.SetFloat("Karbohidrat", karbohidrat);
        PlayerPrefs.SetFloat("Lemak", lemak);
    }
}
