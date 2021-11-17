using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

   public static float wallControlL, wallControlR;

    void Start()
    {
        wallControlL = wallControlR = 0f;
        Debug.Log("WallL = " + wallControlL + " || WallR = " + wallControlR);
    }
   
    void LateUpdate()
    {
       // wallControlL = wallControlR = 0f;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WallL"))
        {
        
            wallControlL = 1f;
            wallControlR = 0f;
            Debug.Log("WallL = " + wallControlL + " || WallR = " + wallControlR);
        }
        if (collision.gameObject.CompareTag("WallR"))
        {
          
            wallControlR = 1f;
            wallControlL = 0f;
            Debug.Log("WallL = " + wallControlL + " || WallR = " + wallControlR);
        }
    }
 

}
