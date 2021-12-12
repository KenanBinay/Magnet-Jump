using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public GameObject PauseButton;
    public static bool GameEnd;

    public RectTransform GameEndScreen;
    Vector3 newPosDown = new Vector3(0, -597f, -2377f);
    Vector3 newPosUp = new Vector3(0, -55f, -2377f);
    private Vector3 endVelocity = Vector3.zero;

    void Start()
    {
        
    }
   
    void FixedUpdate()
    {
        if (Player.Healt <= 0f)
        {
            ControllerMove.rotating = true;
            GameEnd = true;
            GameEndScreen.localPosition = Vector3.SmoothDamp(GameEndScreen.localPosition, newPosUp, ref endVelocity, 0.2f);
            PauseButton.SetActive(false);
        }
        else
        {
            ControllerMove.rotating = false;
            GameEnd = false;
            GameEndScreen.localPosition = Vector3.SmoothDamp(GameEndScreen.localPosition, newPosDown, ref endVelocity, 0.2f);
            PauseButton.SetActive(true);
        }
    }
}
