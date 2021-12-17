using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAgainButton : MonoBehaviour
{
    public Transform player;
    public GameObject Confetti;
    public RectTransform HighScoreTxt;
    [SerializeField] private AudioSource ClickSfx;
    public static bool SfxCont;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PlayAgainGame()
    {
        if (SFXonOff.controlSfx == false)
        {
          ClickSfx.Play();
        }
        SfxCont = true;
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
}
