using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool controlPaused;
    void Start()
    {

    }

    void FixedUpdate()
    {
      
    }

    public void PauseGame()
    {
        ControllerMove.rotating = true;
        controlPaused = true;
        gameObject.SetActive(false);
    }

}
