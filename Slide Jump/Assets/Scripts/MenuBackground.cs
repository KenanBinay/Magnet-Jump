using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBackground : MonoBehaviour
{
    public RectTransform GameEndScreen;

    Vector3 newPosDown = new Vector3(0, -597f, -2377f);
    Vector3 newPosUp = new Vector3(0, -55f, -2377f);
    private Vector3 endVelocity = Vector3.zero;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (MenuPlayGame.MenuStart)
        {
            GameEndScreen.localPosition = Vector3.SmoothDamp(GameEndScreen.localPosition, newPosUp, ref endVelocity, 0.2f);
        }
        else
        {
            GameEndScreen.localPosition = Vector3.SmoothDamp(GameEndScreen.localPosition, newPosDown, ref endVelocity, 0.2f);
        }
    }
}
