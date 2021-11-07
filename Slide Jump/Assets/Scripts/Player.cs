using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float scoreRate = 1.5f;
    float scorespeed = 0.0f;

    void Start()
    {
        
    }
   
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WallL"))
        {
            Debug.Log("WallL");
        }
        if (collision.gameObject.CompareTag("WallR"))
        {
            Debug.Log("WallR");
        }
    }
 

}
