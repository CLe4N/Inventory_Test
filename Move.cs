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
        rb = GetComponent<Rigidbody2D>(); // access Rigidbody2D , SpriteRenderer , Animator component
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        move();
    }

    void move()
    {
        float Xaxis, Yaxis;
        Xaxis = Input.GetAxisRaw("Horizontal"); // get axis input "Horizontal"
        Yaxis = Input.GetAxisRaw("Vertical"); // get axis input "Vertical"

        if (Xaxis != 0 || Yaxis != 0) // if Xaxis and Yaxis is not equal 0
        {
            rb.velocity = new Vector2(Xaxis * speed, Yaxis * speed); // velocity = axis inpput
            anim.SetBool("Walk", true); // play animation Walk
            if(Xaxis > 0) // if Xaxis > 0
            {
                sr.flipX = false; // flip sprite on x axis
            }
            if(Xaxis < 0) // if Xaxis < 0
            {
                sr.flipX = true; // cancel flip
            }
        }
        else
        {
            rb.velocity = Vector2.zero; // velocity = 0
            anim.SetBool("Walk", false); // stop animation Walk
        }
    }
}
