using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private GameObject doors;

    private void Update()
    {
        if (SpawnVrag.KolvoVrag > 0)
        {
            doors.SetActive(true);   
        }
        if (SpawnVrag.KolvoVrag <= 0)
        {
            doors.SetActive(false);
        }
    }

}
      
