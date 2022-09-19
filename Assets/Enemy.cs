using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 5f;
    bool Right = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(rb.velocity.x == 26.02f)
        {
            //rb.velocity = new Vector2(speed, rb.velocity.y);
            Right = false;
        }
        else if(rb.velocity.x == 17.08f)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            //Right = true;
        }
        if(Right)
            rb.velocity = new Vector2(speed, rb.velocity.y);
        else
            rb.velocity = new Vector2(-speed, rb.velocity.y);
    }
    void Flip()
    {
        if (Right)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (!Right)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
