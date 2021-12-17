using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    public RectTransform PauseScreenA;
    private Vector3 buttonVelocity = Vector3.zero;

    Vector3 newPosDown = new Vector3(0, -597f, -2377f);
    Vector3 newPosUp = new Vector3(0, -53f, -2377f);

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (MenuPlayGame.MenuStart == false)
        {
            if (Pause.controlPaused == false)
            {
                PauseScreenA.localPosition = Vector3.SmoothDamp(PauseScreenA.localPosition, newPosDown, ref buttonVelocity, 0.1f);
            }
            else if (Pause.controlPaused)
            {
                PauseScreenA.localPosition = Vector3.SmoothDamp(PauseScreenA.localPosition, newPosUp, ref buttonVelocity, 0.1f);
            }
        }
        if (MenuPlayGame.MenuStart)
        {
            if (Pause.controlPaused == false)
            {
                PauseScreenA.localPosition = Vector3.SmoothDamp(PauseScreenA.localPosition, newPosDown, ref buttonVelocity, 0.1f);
            }
        }
    }
}
