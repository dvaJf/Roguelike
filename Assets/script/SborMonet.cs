using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SborMonet : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "pers")
        {
            Bank.money++;
            Destroy(gameObject);
        }
    }
}
