using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeGameOver : MonoBehaviour
{
    public GameObject HighScoreConfetti, magnet;
    [SerializeField] private AudioSource ClickSfx;

    void Start()
    {
        
    }

  
    void FixedUpdate()
    {
        
    }

    public void HomeReturn()
    {
        if (SFXonOff.controlSfx == false)
        {
            ClickSfx.Play();
        }

        PlayAgainButton.isHighScore = false;

        Spike.spawnCntrl = 0f;
        ScoreController.Score = 0f;
        Spike.spawnRate = 4f;
        MenuPlayGame.MenuStart = true;
        Pause.controlPaused = false;
        magnet.SetActive(true);
        HighScoreConfetti.SetActive(false);
    }
}
