using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooksManager : MonoBehaviour
{
    [Header("GameObject Gizi")]
    [SerializeField] private GameObject[] infoGizi;

    public void info1()
    {
        infoGizi[0].gameObject.SetActive(true);

        infoGizi[1].gameObject.SetActive(false);
        infoGizi[2].gameObject.SetActive(false);
        infoGizi[3].gameObject.SetActive(false);
        infoGizi[4].gameObject.SetActive(false);
    }

    public void info2()
    {
        infoGizi[1].gameObject.SetActive(true);

        infoGizi[0].gameObject.SetActive(false);
        infoGizi[2].gameObject.SetActive(false);
        infoGizi[3].gameObject.SetActive(false);
        infoGizi[4].gameObject.SetActive(false);
    }

    public void info3()
    {
        infoGizi[2].gameObject.SetActive(true);

        infoGizi[0].gameObject.SetActive(false);
        infoGizi[1].gameObject.SetActive(false);
        infoGizi[3].gameObject.SetActive(false);
        infoGizi[4].gameObject.SetActive(false);
    }

    public void info4()
    {
        infoGizi[3].gameObject.SetActive(true);

        infoGizi[0].gameObject.SetActive(false);
        infoGizi[1].gameObject.SetActive(false);
        infoGizi[2].gameObject.SetActive(false);
        infoGizi[4].gameObject.SetActive(false);
    }

    public void info5()
    {
        infoGizi[4].gameObject.SetActive(true);

        infoGizi[0].gameObject.SetActive(false);
        infoGizi[1].gameObject.SetActive(false);
        infoGizi[2].gameObject.SetActive(false);
        infoGizi[3].gameObject.SetActive(false);
    }
}
