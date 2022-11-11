using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WaveScript : MonoBehaviour
{
    //public GameObject Player;
    Player player = new Player();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            player.setSpeed((player.getSpeed()/2f));

        }
        


    }
  /*  private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.setSpeed((player.getSpeed() * 2f));

        }



    }*/
}
