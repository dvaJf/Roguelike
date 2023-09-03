using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    [SerializeField] private Vector3 camer;
    [SerializeField] private Vector3 pers;
    [SerializeField] private Camera cam;
    void Start()
    {
        cam = Camera.main.GetComponent<Camera>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("pers"))
        {
            other.transform.position += pers;
            cam.transform.position += camer;
        }
    }

}
