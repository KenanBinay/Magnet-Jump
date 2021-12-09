using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMove : MonoBehaviour
{
    public Controller swipeControls;
    public Transform player;
    public GameObject Magnet;
    public GameObject Left;
    public GameObject Right;
    float playerY;
    float controlL = 0f;
    float controlR = 0f;
    public float horizontalSpeed=1f;

    public static bool rotating = false;
    void Start()
    {
        
    }

   public static float once = 0f;
    void FixedUpdate()
    {       
        playerY = player.transform.rotation.y;
        //   Debug.Log("Y= " + playerY);

      if (rotating == false)
      {
            if (swipeControls.SwipeLeft)
        {
            #region movingLMethod1L
            /*   if (Player.wallControlR == 1f)
                 {
                           controlR = 0f;

                           if (controlL != 1f)
                           {

                               //Magnet.transform.position = new Vector3(-2.8f, -2.1f, 4.02f);
                               Vector3 directionL = new Vector3(-180f, 0f, 0f);

                               StartCoroutine(RotateObject(Magnet, directionL, 0.3f));
                               Debug.Log("Left");
                           }
                           controlL = 1f;          
                   }

               if (once == 0f)
               {
                   if (Player.wallControlL != 1 && Player.wallControlR != 1f)
                   {
                       controlR = 0f;

                       if (controlL != 1f)
                       {
                           Vector3 directionL = new Vector3(-180f, 0f, 0f);

                           StartCoroutine(RotateObject(Magnet, directionL, 0.3f));
                           Debug.Log("Left");
                       }
                       controlL = 1f;
                   }
                   once = 1f;
               }
            */
            //  if (player.transform.position.x >= 3f)
            #endregion

            if (Player.wallControlR == 1f)
            {
                controlR = 0f;

                if (controlL != 1f)
                {

                    //Magnet.transform.position = new Vector3(-2.8f, -2.1f, 4.02f);
                    Vector3 directionL = new Vector3(-180f, 0f, 0f);

                    StartCoroutine(RotateObject(Magnet, directionL, 0.3f));
                    Debug.Log("Left");
                }
                controlL = 1f;
            }

            if (once == 0f)
            {
                if (Player.wallControlL != 1 && Player.wallControlR != 1f)
                {
                    controlR = 0f;

                    if (controlL != 1f)
                    {
                        Vector3 directionL = new Vector3(-180f, 0f, 0f);

                        StartCoroutine(RotateObject(Magnet, directionL, 0.3f));
                        Debug.Log("Left");
                    }
                    controlL = 1f;
                }
                once = 1f;
            }
        }
 

        if (swipeControls.SwipeRight)
        {
            #region movingRMethod1R
            /*   if (Player.wallControlL == 1f)
                   {                 
                           controlL = 0f;

                           if (controlR != 1)
                           {
                               //  Magnet.transform.position = new Vector3(3.3f, -2.1f, 3.87f);
                               Vector3 directionR = new Vector3(180f, 0f, 0f);

                               StartCoroutine(RotateObject(Magnet, directionR, 0.3f));
                               Debug.Log("Right");
                           }
                           controlR = 1f;
                   }

               if (once == 0f)
               {
                   if (Player.wallControlR != 1f && Player.wallControlL != 1f)
                   {
                       controlL = 0f;

                       if (controlR != 1)
                       {

                           Vector3 directionR = new Vector3(180f, 0f, 0f);

                           StartCoroutine(RotateObject(Magnet, directionR, 0.3f));
                           Debug.Log("Right");
                       }
                       controlR = 1f;
                   }
                   once = 1f;
               }

               //  if (player.transform.position.x <= -2.8f)     
            */
            #endregion
         
            if (Player.wallControlL == 1f)
            {
                controlL = 0f;

                if (controlR != 1)
                {
                    //  Magnet.transform.position = new Vector3(3.3f, -2.1f, 3.87f);
                    Vector3 directionR = new Vector3(180f, 0f, 0f);

                    StartCoroutine(RotateObject(Magnet, directionR, 0.3f));
                    Debug.Log("Right");
                }
                controlR = 1f;
            }

            if (once == 0f)
            {
                if (Player.wallControlR != 1f && Player.wallControlL != 1f)
                {
                    controlL = 0f;

                    if (controlR != 1)
                    {

                        Vector3 directionR = new Vector3(180f, 0f, 0f);

                        StartCoroutine(RotateObject(Magnet, directionR, 0.3f));
                        Debug.Log("Right");
                    }
                    controlR = 1f;
                }
                once = 1f;
            }
        }

      }
    }

    IEnumerator RotateObject(GameObject gameObjectToMove, Vector3 eulerAngles, float duration)
    {
        if (rotating)
        {
            yield break;
        }
        rotating = true;

        Vector3 newRot = gameObjectToMove.transform.eulerAngles + eulerAngles;

        Vector3 currentRot = gameObjectToMove.transform.eulerAngles;

        float counter = 0;
        while (counter < duration)
        {
            counter += Time.deltaTime;
            gameObjectToMove.transform.eulerAngles = Vector3.Lerp(currentRot, newRot, counter / duration);
            if (controlL == 1f)
            {
                player.transform.position = Vector3.MoveTowards(player.transform.position, Left.transform.position, Time.deltaTime * horizontalSpeed);
                 // if (player.transform.position.x != 2.6f) { Magnet.transform.position += Vector3.left * horizontalSpeed * Time.deltaTime; }
                 //  Debug.Log("x = " + player.transform.position.x);
                 //  Magnet.transform.position += Vector3.left * horizontalSpeed * Time.deltaTime; 
            }
           else if (controlR == 1f)
            {
                player.transform.position = Vector3.MoveTowards(player.transform.position, Right.transform.position, Time.deltaTime * horizontalSpeed);
                // if (player.transform.position.x != 3.13f) { Magnet.transform.position += Vector3.right * horizontalSpeed * Time.deltaTime; }
                // Magnet.transform.position += Vector3.right * horizontalSpeed * Time.deltaTime;
            }
            yield return null;
        }
        rotating = false;
    }
}
