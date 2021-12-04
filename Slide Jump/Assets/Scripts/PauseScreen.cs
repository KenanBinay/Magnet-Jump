using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    public RectTransform PauseScreenA;
    private Vector3 buttonVelocity = Vector3.zero;
    Vector3 newPosDown = new Vector3(0, -597f, -2059f);

    Vector3 newPosUp = new Vector3(0, -53f, -2059f);
    public GameObject PauseButton;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Pause.controlPaused == false)
        {

            PauseScreenA.localPosition = Vector3.SmoothDamp(PauseScreenA.localPosition, newPosDown, ref buttonVelocity, 0.5f);
        }

        if (Pause.controlPaused)
        {
           
            PauseScreenA.localPosition = Vector3.SmoothDamp(PauseScreenA.localPosition, newPosUp, ref buttonVelocity, 0.5f);
        }
    }
}
