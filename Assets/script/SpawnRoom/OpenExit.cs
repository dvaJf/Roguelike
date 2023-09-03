using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenExit : MonoBehaviour
{
    private GameObject Exit;
    private GameObject Exit1;
    private void Update()
    {
        Exit = GameObject.Find("выход(Clone)");
        if (Exit != null)
        {
            Exit1 = Exit;
        }
        if (Exit1 != null )
        {
            if (SpawnVrag.KolvoVrag > 0)
            {
                Exit1.SetActive(false);
            }
           if (SpawnVrag.KolvoVrag <= 0)
            {
                Exit1.SetActive(true);
            }
        }
       
    }

}
