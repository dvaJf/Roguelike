using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVrag : MonoBehaviour
{
    [SerializeField] private GameObject Vrag;
    private Vector3 rng;
    private Vector3 PositionDefolt;
    public static int KolvoVrag = 0;
    bool spaw = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "pers" && spaw)
        {
            PositionDefolt = transform.position;
            System.Random rnd = new System.Random();
            int i = rnd.Next(1, 5);
            while (i > 0)
            {
                spawn();
                i--;
            }
        }
 
    }
    private void spawn()
    {
        rng.x = Random.Range(-4,4);
        rng.y = Random.Range(-1,1);
        rng.z = 100;
        Instantiate(Vrag, PositionDefolt + rng, Quaternion.identity);
        KolvoVrag++;
        spaw = false;
    }

}
