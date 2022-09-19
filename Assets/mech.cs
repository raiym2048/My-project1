using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class mech : MonoBehaviour
{
    // Start is called before the first frame update
    public Text score;
    public int counter = 0;
    private void Start()
    {
        score.text = "Score: "+ counter+1;
    }
    //public int counter = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            Destroy(gameObject);
            counter++;
            score.text = "Score: " + counter;
            Debug.Log(counter);
            
        }
        if (collision.gameObject.tag == "Player" && gameObject.tag == "finish")
        {
            SceneManager.LoadScene(1);
        }


    }
}
