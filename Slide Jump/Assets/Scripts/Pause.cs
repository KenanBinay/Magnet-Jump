using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool controlPaused;
    [SerializeField] private AudioSource ClickSfx;
    void Start()
    {

    }

    void FixedUpdate()
    {
      
    }

    public void PauseGame()
    {
        if (SFXonOff.controlSfx == false)
        {
            ClickSfx.Play();
        }
        ControllerMove.rotating = true;
        controlPaused = true;
        
    }

}
