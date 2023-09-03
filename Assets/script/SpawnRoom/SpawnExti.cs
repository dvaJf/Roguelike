using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnExti : MonoBehaviour
{
    [SerializeField] private GameObject Exit;
    private Vector3 rng;
    private Vector3 PositionDefolt;
    bool spaw = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        PositionDefolt = transform.position;
        if (other.tag == "pers" && spaw)
        {
            spawn();
        }

    }

    private void spawn()
    {
        rng.x = Random.Range(-4, 4);
        rng.y = Random.Range(-1, 1);
        rng.z = 100;
        Instantiate(Exit, PositionDefolt + rng, Quaternion.identity);
        spaw = false;
    }
}
