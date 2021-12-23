using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialControl : MonoBehaviour
{
    public GameObject Hand, Txt;
    public Animator handAnim, TxtAnim;
    void Start()
    {
        Hand.SetActive(false);
        Txt.SetActive(false);   
       
    }

    void FixedUpdate()
    {
        if (ControllerMove.rotating)
        {
            if (Pause.controlPaused == false)
            {
                Hand.SetActive(false);
                Txt.SetActive(false);
            }        
        }
    }
}
