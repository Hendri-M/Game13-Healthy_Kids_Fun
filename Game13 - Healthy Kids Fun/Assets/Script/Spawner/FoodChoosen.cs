using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodChoosen : MonoBehaviour
{
    [SerializeField] Button btn;
    
    public void burger()
    {
        Debug.Log("Memilih Burger");
    }

    public void cake()
    {
        Debug.Log("Memilih Cake");
    }

    public void friedchicken()
    {
        Debug.Log("Memilih Fried Chicken");
    }
}
