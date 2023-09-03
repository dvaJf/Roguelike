using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "pers")
        {
            Bank.Key = 0;
            Bank.money = 0;
            SpawnVrag.KolvoVrag = 0;

            SceneManager.LoadScene("Win");
        }
     
    }
}


