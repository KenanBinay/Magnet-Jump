using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject PauseButton;
    void Start()
    {
        
    }

   
    void FixedUpdate()
    {
        
    }

    public void ResumeButton()
    {
        ControllerMove.rotating = false;
        Pause.controlPaused = false;
        PauseButton.SetActive(true);
    }
}
