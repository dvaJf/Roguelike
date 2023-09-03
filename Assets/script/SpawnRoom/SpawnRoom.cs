
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Threading.Tasks;

public class SpawnRoom : MonoBehaviour
{

    public Naprav narav;
    public enum Naprav
    {
        verx,
        niz,
        levo,
        pravo,
        net
    }
    private rooms room;
    private int vabor;
    private bool spawn;

    private void Start()
    {
       
        room = GameObject.FindGameObjectWithTag("rooms").GetComponent<rooms>();
        System.Random x = new System.Random();
        Invoke("Spawn", (float)x.NextDouble());
        Destroy(gameObject, 1f);
    }
    public void Spawn()
    {
        if (!spawn)
        {
            if (narav == Naprav.verx)
            {
                vabor = Random.Range(0, room.VerxRoom.Length);
                Instantiate(room.VerxRoom[vabor], transform.position, room.VerxRoom[vabor].transform.rotation);
            }
            else if (narav == Naprav.levo)
            {
                vabor = Random.Range(0, room.LevoRoom.Length);
                Instantiate(room.LevoRoom[vabor], transform.position, room.LevoRoom[vabor].transform.rotation);
            }
            else if (narav == Naprav.niz)
            {
                vabor = Random.Range(0, room.VerxRoom.Length);
                Instantiate(room.NizRoom[vabor], transform.position, room.NizRoom[vabor].transform.rotation);
            }
            else if (narav == Naprav.pravo)
            {
                vabor = Random.Range(0, room.PravoRoom.Length);
                Instantiate(room.PravoRoom[vabor], transform.position, room.PravoRoom[vabor].transform.rotation);
            }
            spawn = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("spawn") && other.GetComponent<SpawnRoom>().spawn)
        {
            Destroy(gameObject);
        }
    }
}
