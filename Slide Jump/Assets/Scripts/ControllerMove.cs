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

    bool rotating = false;
    void Start()
    {
        
    }
   
    void Update()
    {       
        playerY = player.transform.rotation.y;
        //   Debug.Log("Y= " + playerY);

            if (swipeControls.SwipeLeft)
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

            if (swipeControls.SwipeRight)
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
            yield return null;
        }
        rotating = false;
    }
}
