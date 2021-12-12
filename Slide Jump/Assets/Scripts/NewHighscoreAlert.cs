using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHighscoreAlert : MonoBehaviour
{
    Vector3 newPosUp = new Vector3(-3.4f, 4.26f, -4.37468f);
    Vector3 newPosDown = new Vector3(-3.4f, -3.5f, -4.37468f);
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
