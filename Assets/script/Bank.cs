using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bank : MonoBehaviour
{
    [SerializeField] Text MoneyText;
    [SerializeField] Text KeyText;
    public static int Key = 0;
    public static int money = 0;

    
    void Update()
    {
        MoneyText.text = System.Convert.ToString(money);
        KeyText.text = System.Convert.ToString(Key);
    }
}
