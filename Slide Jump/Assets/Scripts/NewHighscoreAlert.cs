using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHighscoreAlert : MonoBehaviour
{
    Vector3 newPosUp = new Vector3(-2.5086f, 4.1f, -6.1475f);
    Vector3 newPosDown = new Vector3(-2.5086f, -3.5f, -6.1475f);
    private Vector3 endVelocity = Vector3.zero;

    void Start()
    {
        
    }

   
    void FixedUpdate()
    {
        if (Player.Healt <= 0f)
        {
            if (ScoreController.HighScoreAlertTxt)
            {
                transform.localPosition = Vector3.SmoothDamp(transform.localPosition, newPosUp, ref endVelocity, 0.2f);
            }
        }
        else
        {
            transform.localPosition = Vector3.SmoothDamp(transform.localPosition, newPosDown, ref endVelocity, 0.2f);
        }
    }
}
