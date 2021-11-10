using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    

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
