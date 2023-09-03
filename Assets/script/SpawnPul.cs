using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPul : MonoBehaviour
{
    [SerializeField] private Transform pers;
    [SerializeField] private GameObject pula;
    [SerializeField] private float VadorPerezarad;
    private float perezarad;
    private void Start()
    {
        perezarad = VadorPerezarad;
    }
    private void Update()
    {
        if (perezarad <= VadorPerezarad)
        {
            perezarad += Time.deltaTime;
        }
        
        if (perezarad > (VadorPerezarad - 0.001))
        {
            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                Instantiate(pula, pers.position, pers.rotation);
                perezarad = 0;
            }
        }
    }
}
    