using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform FirePoint;
    public GameObject bulletPrefab;
    

    void Update()
    {
        
    }
    public void Shoot()
    {
        
        
            Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
        
       
    }
    
}
