using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool controlPaused;
    public Animator handAnim, TxtAnim;
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

        handAnim.enabled = false;
        TxtAnim.enabled = false;

        ControllerMove.rotating = true;
        controlPaused = true;
        
    }

}
