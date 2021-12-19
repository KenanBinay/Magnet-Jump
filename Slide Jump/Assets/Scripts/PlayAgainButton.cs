using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAgainButton : MonoBehaviour
{
    public Transform player;
    public GameObject Confetti;
    public RectTransform HighScoreTxt;
    [SerializeField] private AudioSource ClickSfx, ConfettiSfx, NewHighScoreSfx;
    public static bool SfxCont, isHighScore, highScorePlaying;
   
    void Start()
    {
        AudioSource ConfettiSfx = GetComponent<AudioSource>();
        AudioSource NewHighScoreSfx = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        if (Player.Healt <= 0f)
        {
            SfxCont = false;

            if (ScoreController.SfxScore == PlayerPrefs.GetFloat("HighScore", 0))
            {
                StartCoroutine(WaitSfx());

                if (isHighScore && highScorePlaying)
                {
                    ConfettiSfx.Play();
                    NewHighScoreSfx.Play();
                    highScorePlaying = false;
                    ScoreController.SfxScore = 0f;      
                }

            }

            if (MenuPlayGame.MenuStart)
            {
                ConfettiSfx.Stop();
                NewHighScoreSfx.Stop();
            }
        }

    }

    public void PlayAgainGame()
    {

        ConfettiSfx.Stop();
        NewHighScoreSfx.Stop();

        SfxCont = true;

        if (SFXonOff.controlSfx == false)
        {
          ClickSfx.Play();
        }

        isHighScore = false;
        Player.Healt = 50f;
        Spike.spawnCntrl = 1f;
        Player.SpikeControl = false;
        Pause.controlPaused = false;
        GameOverScreen.GameEnd = false;
        ScoreController.Score = 0f;
        ScoreController.SfxScore = 0f;
        SpikeMovement.SpeedCharacter = 8f;
        Spike.spawnRate = 4f;
        SpikeMovement.SpeedCharacter = 8f;
        ScoreController.HighScoreAlertTxt = false;
        Confetti.SetActive(false);
        ScoreController.GameOverScore = 0f;

        Player.wallControlL = 0f;
        Player.wallControlR = 0f;
        ControllerMove.once = 0f;
        player.position = new Vector3(0.32f, -2.1f, 3.952506f);
        HighScoreTxt.localScale = new Vector3(0.031f, 0.031f, 0.031f);

        ControllerMove.rotating = false;
    }
    IEnumerator WaitSfx()
    {
        isHighScore = true;
        highScorePlaying = true;
        yield break;
    }
}
