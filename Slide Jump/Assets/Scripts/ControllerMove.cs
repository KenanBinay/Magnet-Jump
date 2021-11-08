using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMove : MonoBehaviour
{
    public Controller swipeControls;
    public Transform player;
    private Vector3 desiredPosition;
    float playerY;
    void Start()
    {

     
    }

    void Update()
    {
        playerY = player.transform.rotation.y;
     //   Debug.Log("Y= " + playerY);

        if (playerY<=0)
        {
            if (swipeControls.SwipeLeft)
                player.transform.Rotate(0, 180, 0);
        }
        if(playerY>=0)
        {
            if (swipeControls.SwipeRight)
                player.transform.Rotate(0, -180, 0);
        }
 
    }
}
