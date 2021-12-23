using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject PauseButton;
    public Animator handAnim, TxtAnim;
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

        handAnim.enabled = true;
        TxtAnim.enabled = true;

        ControllerMove.rotating = false;
        Pause.controlPaused = false;
    
    }
}
