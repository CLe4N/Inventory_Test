using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    Animator anim;
    [SerializeField] float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        float Xaxis, Yaxis;
        Xaxis = Input.GetAxisRaw("Horizontal");
        Yaxis = Input.GetAxisRaw("Vertical");

        if (Xaxis != 0 || Yaxis != 0)
        {
            rb.velocity = new Vector2(Xaxis * speed, Yaxis * speed);
            anim.SetBool("Walk", true);
            if(Xaxis > 0)
            {
                sr.flipX = false;
            }
            if(Xaxis < 0)
            {
                sr.flipX = true;
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
            anim.SetBool("Walk", false);
        }
    }
}
