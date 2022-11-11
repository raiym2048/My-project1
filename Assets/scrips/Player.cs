using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    float time = 0f;

    

   // public Button button;

    public Joystick joystick;
    //public Button button;


    
    
    public float speed = 3.5f;
    public float JumpHeight = 7f;

    public Transform groundCheck;
    public Transform upCheck;
    bool IsNotdelay = true;

    Animator anim;
    bool isGrounded;
    int counter = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    public void setSpeed(float speed)
    {
        this.speed = speed;
    }
    public float getSpeed()
    {
        return speed;
    }



    // Update is called once per frame//     P@ssword
    void Update()
    {
        
        transform.position += new Vector3(-joystick.Horizontal * speed * Time.deltaTime, 0f, 0f);
        time += Time.deltaTime;
        //Debug.Log(IsNotdelay);

        if(transform.position.y < -6)
        {
            SceneManager.LoadScene(0);
        }

        //rb.velocity = new Vector2(-joystick.Horizontal * speed, rb.velocity.y);
        Flip();

        CheckGround();
        CheckUp();
        //Jump();//
        Attack();
        if (!isGrounded)
            anim.SetInteger("State", 10);
        else
            anim.SetInteger("State", 1);
        if (joystick.Horizontal != 0 && isGrounded)
        {
            anim.SetInteger("State", 12);
        }
        else if (joystick.Horizontal == 0 && isGrounded)
        {
            anim.SetInteger("State", 1);
        }



    }
    
    private void FixedUpdate()
    {
        
        
        
    }
   
    void Flip()
    {
        
        /*transform.localRotation = Input.GetAxis("Horizontal") > 0 ? Quaternion.Euler(0, 0, 0) :
            Input.GetAxis("Horizontal") < 0 ? Quaternion.Euler(0, 180, 0) : transform.localRotation;*/
        if(joystick.Horizontal < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if(joystick.Horizontal > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        



    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }*/
    void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, 0.2f);
        isGrounded = colliders.Length > 1;
        
    }
    void CheckUp()
    {
        Collider2D[] collider2s = Physics2D.OverlapBoxAll(upCheck.position, new Vector2(0.2f, 0.2f), 0.2f);
        IsNotdelay = collider2s.Length > 2;
        if (collider2s.Length > 2)
        {
            anim.SetInteger("State", 8);
            time = 0;
        }
            
    }
    public void Jump()
    {
        //int cm = 0;
        if (isGrounded)
        {
            counter = 0;
        }

        if (counter < 2)
        {
            //rb.AddForce(transform.up * JumpHeight, ForceMode2D.Impulse);
            
            rb.velocity = Vector2.up * JumpHeight;
         

            counter++;
            //
        }
        
    }
    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            anim.SetInteger("State", 2);
        }
    }
    
}
