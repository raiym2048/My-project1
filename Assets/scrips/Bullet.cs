using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision);
        Destroy(gameObject);
        collision.GetComponent<Renderer>().enabled = false;
    }
    void Update()
    {
        if(transform.position.x > 70 || transform.position.x < -30)
        {
            Destroy(gameObject);
        }
    }
    
    

    // Update is called once per frame

}
