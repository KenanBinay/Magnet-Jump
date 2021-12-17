using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject PauseButton;
    [SerializeField] private AudioSource ClickSfx;
    void Start()
    {
        
    }

   
    void FixedUpdate()
    {
        
    }

    public void ResumeButton()
    {
        if (SFXonOff.controlSfx == false)
        {
            ClickSfx.Play();
        }
        ControllerMove.rotating = false;
        Pause.controlPaused = false;
    
    }
}
