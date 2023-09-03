using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HizikaPuli : MonoBehaviour
{
    [SerializeField] private float spped = 1;
    [SerializeField] private Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "stena")
        {
            Destroy(gameObject);
        }
        if (other.tag == "dver")
        {
            Destroy(gameObject);
        }
      
    }
    private void Start()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity = transform.right * spped;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.velocity = transform.right * spped * -1;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = transform.up * spped;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.velocity = transform.up * spped * -1;
        }

    }
    private void Update()
    {
        transform.Rotate(0, 0, 1);
    }
}
