using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    // Start is called before the first frame update
    bool CanJump = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //void OnTrigger
     private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.tag == "GroundD")
        {
            CanJump = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
    
        if (collision.tag == "GroundD")
        {
            CanJump = false;
        }
    }
    

    public bool Ch()
    {
        return CanJump;
    }
}
