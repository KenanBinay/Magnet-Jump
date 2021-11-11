using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMove : MonoBehaviour
{
    public Controller swipeControls;
    public Transform player;
    public GameObject Magnet;
    float playerY;
    float controlL = 0f;
    float controlR = 0f;
    public float horizontalSpeed=1f;

    bool rotating = false;
    void Start()
    {
        
    }

    Vector2 directionXR = new Vector2(3.27f, 0f);
    Vector2 directionXL = new Vector2(-2.78f, 0f);

    void Update()
    {       
        playerY = player.transform.rotation.y;
        //   Debug.Log("Y= " + playerY);

            if (swipeControls.SwipeLeft)
            {
                Player.wallControlL =Player.wallControlL= 0f;
                controlR = 0f;

            if (Player.wallControlL == 1f)
            {
                controlR = 0f;
                controlL = 1f;
            }

            if (controlL != 1f)
            {

                //Magnet.transform.position = new Vector3(-2.8f, -2.1f, 4.02f);
                Vector3 directionL = new Vector3(-180f, 0f, 0f);

                StartCoroutine(RotateObject(Magnet, directionL, 0.3f));
                Debug.Log("Left");
            }
            controlL = 1f;
            }                  
  
            if (swipeControls.SwipeRight)
            {
                Player.wallControlL = Player.wallControlL = 0f;
                controlL = 0f;

            if (Player.wallControlR == 1f)
            {
                controlL = 0f;
                controlR = 1f;
            }

            if (controlR != 1)
            {
                //  Magnet.transform.position = new Vector3(3.3f, -2.1f, 3.87f);
                Vector3 directionR = new Vector3(180f, 0f, 0f);

                StartCoroutine(RotateObject(Magnet, directionR, 0.3f));
                Debug.Log("Right");
            }
            controlR = 1f;
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
                 if(Player.wallControlL!=1)
                 Magnet.transform.position += Vector3.left * horizontalSpeed * Time.deltaTime; 
            }
            if (controlR == 1f)
            {
                 if(Player.wallControlR != 1)
                 Magnet.transform.position += Vector3.right * horizontalSpeed * Time.deltaTime;
            }
            yield return null;
        }
        rotating = false;
    }
}
