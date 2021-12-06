using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
   [SerializeField] TMPro.TextMeshProUGUI GameScoreMain, HighScore;
    public float ScoreRate;
    public static float Score,scorePlus=2;
    public static float scoreSpeed = 0.0f;
    void Start()
    {
        Debug.Log("HigScore = " + PlayerPrefs.GetFloat("HighScore"));
    }

    void FixedUpdate()
    {
        if (Player.Healt <= 0f)
        {          
            if (Score > PlayerPrefs.GetFloat("HighScore", 0))
            {
                PlayerPrefs.SetFloat("HighScore", Score);
                Debug.Log("HigScore Saved = " + PlayerPrefs.GetFloat("HighScore"));
            }
        }
        else if (Player.Healt >= 1f)
        {
            if (Pause.controlPaused != true)
            {
                if (Time.time > scoreSpeed)
                {
                    scoreSpeed = Time.time + ScoreRate;
                    GameScoreMain.text = Score.ToString();
                    Score += scorePlus;
                }
            }
        }
    }
}
