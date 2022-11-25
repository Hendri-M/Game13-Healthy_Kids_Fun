using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PilihKarakter : MonoBehaviour
{
    [SerializeField] Image karakterCowo;
    [SerializeField] Image karakterCewe;
    [SerializeField] Animator animateCowo;
    [SerializeField] Animator animateCewe;

    bool isIdle;

    private void Start()
    {
        isIdle = false;    
    }
    public void pilihCowo()
    {
        animateCewe.SetBool("IdleCewe", false);
        Debug.Log("Cowo");
        isIdle = true;
        animateCowo.SetBool("IdleCowo", isIdle);
    }
    
    public void pilihCewe()
    {
        animateCowo.SetBool("IdleCowo", false);
        Debug.Log("Cewe");
        isIdle = true;
        animateCewe.SetBool("IdleCewe", isIdle);
    }
}
