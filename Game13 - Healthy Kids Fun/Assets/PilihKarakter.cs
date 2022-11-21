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
    float pilihKarakter;

    private void Start()
    {
        isIdle = false; 
    }
    
    public void pilihCowo(int pilih)
    {
        animateCewe.SetBool("IdleCewe", false);
        
        pilihKarakter = pilih;
        isIdle = true;
        animateCowo.SetBool("IdleCowo", isIdle);
    }
    
    public void pilihCewe(int pilih)
    {
        animateCowo.SetBool("IdleCowo", false);
        
        pilihKarakter = pilih;
        isIdle = true;
        animateCewe.SetBool("IdleCewe", isIdle);
    }

    public void savePilihan()
    {
        PlayerPrefs.SetFloat("Karakter", pilihKarakter);
    }
}
