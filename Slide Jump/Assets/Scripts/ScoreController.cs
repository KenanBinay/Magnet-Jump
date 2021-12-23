using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI GameScoreMain, ScoreGameEnd, Highscore, MenuScore;
    public float ScoreRate, ScoreRate2;
    public static float Score, scorePlus = 2;
    public static float scoreSpeed = 0.0f, scoreSpeedGameOver, GameOverScore, SfxScore;
    public GameObject HighScoreConfetti,NewHighScoreTxt;
    public RectTransform GameEndScreen,HighScoreTxt;
    public float SeedHeight, FinalHeigh, Speed;
    public static bool HighScoreAlertTxt;

    float controlSfx;
    [SerializeField] private AudioSource HighScoreSfx, ConfettiSfx, ScoreSfx;
    void Start()
    {
        PlayerPrefs.SetFloat("HighScore", 10f);
        SfxScore = 0f;
        HighScoreTxt.localScale = new Vector3(0.031f, 0.031f, 0.031f);
        NewHighScoreTxt.SetActive(false);
        HighScoreConfetti.SetActive(false);
        Score = 0f;
        Debug.Log("HigScore = " + PlayerPrefs.GetFloat("HighScore"));
        Highscore.text = PlayerPrefs.GetFloat("HighScore").ToString();
        MenuScore.text = PlayerPrefs.GetFloat("HighScore").ToString();
    }
    bool Waited;
    void FixedUpdate()
    {

        if (MenuPlayGame.MenuStart == true)
        {
            MenuScore.text = PlayerPrefs.GetFloat("HighScore").ToString();
        }

        if (MenuPlayGame.MenuStart == false)
        {
            if (Player.Healt <= 0f)
            {
                if (GameOverScreen.GameEnd)
                {

                    StartCoroutine(WaitJust());

                    if (Waited == true)
                    {
                        if (Time.time > scoreSpeedGameOver)
                        {
                            scoreSpeedGameOver = Time.time + ScoreRate2;
                            if (ScoreGameEnd.text != Score.ToString())
                            {
                                ScoreGameEnd.text = GameOverScore.ToString();
                                GameOverScore++;
                                ScoreSfx.Play();
                                ScoreSfx.loop = true;
                            }
                            else if (ScoreGameEnd.text == Score.ToString())
                            {
                                ScoreSfx.Stop();
                                ScoreSfx.loop = false;

                            }

                        }

                        if (GameOverScore > PlayerPrefs.GetFloat("HighScore", 0))
                        {

                            HighScoreConfetti.SetActive(true);
                            NewHighScoreTxt.SetActive(true);
                            HighScoreAlertTxt = true;

                            if (PlayAgainButton.isHighScore == false)
                            {
                                SfxScore = PlayerPrefs.GetFloat("HighScore", 0);
                            }

                            PlayerPrefs.SetFloat("HighScore", Score);
                            Highscore.text = PlayerPrefs.GetFloat("HighScore").ToString();

                            Debug.Log("HigScore Saved = " + PlayerPrefs.GetFloat("HighScore"));

                            StartCoroutine(HighScoreScale());
                            //    StartCoroutine(WaitSfx());
                        }

                    }
                }
            }
        }
        if (MenuPlayGame.MenuStart == false)
        {
            if (Player.Healt >= 1f)
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

    public IEnumerator HighScoreScale()
    {
        yield return new WaitForSeconds(1.3f);
        HighScoreTxt.localScale = new Vector3(0.04f, 0.04f, 0.04f);       
    }
    public IEnumerator WaitJust()
    {
        yield return new WaitForSeconds(0.7f);
        Waited = true;
    }
    public IEnumerator WaitSfx()
    {
        //  yield return new WaitForSeconds(7.5f);
        if (SfxScore != PlayerPrefs.GetFloat("HighScore", 0))
        {
            ConfettiSfx.Play();
            HighScoreSfx.Play();

            if (PlayAgainButton.SfxCont)
            {
                ConfettiSfx.Stop();
                HighScoreSfx.Stop();
                ConfettiSfx.loop = false;
                HighScoreSfx.loop = false;
            }

            if (MenuPlayGame.MenuStart)
            {
                ConfettiSfx.Stop();
                HighScoreSfx.Stop();
                ConfettiSfx.loop = false;
                HighScoreSfx.loop = false;
            }
        }
      
        yield break;
    }
  
}
