using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiVrag : MonoBehaviour
{
    Transform target;
    GameObject pers;
    public float speed;

    /*[SerializeField] private Animator anim;
    private Vector2 naprav;*/
    private void Update()
    {
        pers = GameObject.Find("персонаж 1");
        target = pers.GetComponent<Transform>();
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed);

       /* anim.SetFloat("vertical", naprav.x);
        anim.SetFloat("zorizont", naprav.y);
        anim.SetFloat("Speed", naprav.sqrMagnitude);*/
    }
}
