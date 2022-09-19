using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject gameObject;
    private bool getIt;

    //public global::System.Boolean GetIt { get => getIt; set => getIt = value; }
    public void Seta(bool m)
    {
        getIt = m;
    }
    public bool Geta() => getIt;

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
        if(collision.tag != "Player")
        {
            getIt = true;
        }
    }

   
}
