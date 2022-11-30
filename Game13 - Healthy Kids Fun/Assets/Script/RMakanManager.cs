using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RMakanManager : MonoBehaviour
{
    [SerializeField] Button nextButton;
    [SerializeField] Image loadKarakter;
    [SerializeField] Sprite[] poseKarakter;
    [SerializeField] TMP_Text energiGizi;
    [SerializeField] GameObject panelGizi;
    [SerializeField] GameObject panelWarning;

    int karakterTerpilih;

    float energi;

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

        nextButton.interactable = false;
        panelGizi.SetActive(false);
        panelWarning.SetActive(false);
        
    }

    public void menuMakanan1()
    {
        Debug.Log("Makanan1");
        energiGizi.text = "" + energi;
        
        poseSenyum();

        StartCoroutine(changePose());
    }

    public void menuMakanan2()
    {
        Debug.Log("Makanan2");
        poseSenyum();

        StartCoroutine(changePose());
    }

    public void menuMakanan3()
    {
        Debug.Log("Makanan3");
        poseSenyum();

        StartCoroutine(changePose());
    }

    public void menuMakanan4()
    {
        Debug.Log("Makanan4");
        poseSenyum();

        StartCoroutine(changePose());
    }

    public void menuMakanan5()
    {
        Debug.Log("Makanan5");
        poseSenyum();

        StartCoroutine(changePose());
    }

    public void piringKosong()
    {
        poseTerkejut();

        StartCoroutine(warningPanel());
        StartCoroutine(changePose());
    }

    IEnumerator warningPanel()
    {
        yield return new WaitForSeconds(1.5f);
        panelWarning.SetActive(true);
    }

    IEnumerator changePose()
    {
        yield return new WaitForSeconds(1);
        poseNormal();
    }


    public void poseNormal()
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

    public void poseSenyum()
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

    public void poseTerkejut()
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
    
    public void saveStats()
    {
        PlayerPrefs.SetFloat("Energi", energi);
    }

}
