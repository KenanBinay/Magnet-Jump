using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAgainButton : MonoBehaviour
{
    public Transform player;
    public GameObject Confetti;
    public RectTransform HighScoreTxt;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PlayAgainGame()
    {
        Player.Healt = 50f;
        Spike.spawnCntrl = 1f;
        Player.SpikeControl = false;
        Pause.controlPaused = false;
        GameOverScreen.GameEnd = false;
        ScoreController.Score = 0f;
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
        HighScoreTxt.localScale = new Vector3(0.04f, 0.04f, 0.04f);

        ControllerMove.rotating = false;
    }
}
