using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadVrag : MonoBehaviour
{
    [SerializeField] private GameObject VragDead;
    private Vector3 PositionVrag;
    [SerializeField] private int health;
    [SerializeField] private GameObject coin;
    [SerializeField] private GameObject key;
    [SerializeField] private GameObject heal;
    private void OnTriggerEnter2D(Collider2D other)
    {
        PositionVrag = transform.position;
        if (other.tag == "pula")
        {

            Destroy(other.gameObject);
            health--;

        }
    }

    private void Drop()
    {
        System.Random drop = new System.Random();
        int Drop = drop.Next(1, 10);
        switch (Drop)
        {
            case 1:
                Instantiate(coin, PositionVrag, Quaternion.identity);
                break;

            case 2:
                Instantiate(key, PositionVrag, Quaternion.identity);
                break;
            case 3:
                Instantiate(heal, PositionVrag, Quaternion.identity);
                break;
            default:
                break;

        }

    }

    private void Update()
    {
        if (health <= 0)
        {
            Drop();


            SpawnVrag.KolvoVrag--;
            Destroy(gameObject);
            Instantiate(VragDead, PositionVrag, Quaternion.identity);
        }
    }
}
