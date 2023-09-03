using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moviePers : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Animator anim;
    private Vector2 naprav;
    private Rigidbody2D rd;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        naprav.x = Input.GetAxisRaw("Horizontal");
        naprav.y = Input.GetAxisRaw("Vertical");
        anim.SetFloat("vertical",naprav.x);
        anim.SetFloat("zorizont", naprav.y);
        anim.SetFloat("Speed", naprav.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        rd.MovePosition(rd.position + naprav * speed);
    }
}
