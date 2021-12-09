using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI GameScoreMain, ScoreGameEnd, Highscore;
    public float ScoreRate;
    public static float Score,scorePlus=2;
    public static float scoreSpeed = 0.0f;
    void Start()
    {
        Score = 0f;
        Debug.Log("HigScore = " + PlayerPrefs.GetFloat("HighScore"));
        Highscore.text = PlayerPrefs.GetFloat("HighScore").ToString();
    }

    void FixedUpdate()
    {
        if (Player.Healt <= 0f)
        {
            ScoreGameEnd.text = Score.ToString();
            if (Score > PlayerPrefs.GetFloat("HighScore", 0))
            {
                PlayerPrefs.SetFloat("HighScore", Score);
                Highscore.text = PlayerPrefs.GetFloat("HighScore").ToString();
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
