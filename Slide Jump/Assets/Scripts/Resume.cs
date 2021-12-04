using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject PauseButton, PauseScreen;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void ResumeButton()
    {
        ControllerMove.rotating = false;
        Pause.controlPaused = false;
        PauseButton.SetActive(true);
        PauseScreen.SetActive(false);
    }
}
