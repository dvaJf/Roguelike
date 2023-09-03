using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixFalseDoor : MonoBehaviour
{
    [SerializeField] GameObject stena;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "stena")
        {
            Instantiate(stena, transform.GetChild(0).position, Quaternion.identity); 
            Instantiate(stena, transform.GetChild(1).position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
