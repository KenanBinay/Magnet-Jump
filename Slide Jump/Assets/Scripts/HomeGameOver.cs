using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeGameOver : MonoBehaviour
{
    public GameObject HighScoreConfetti, magnet;
    void Start()
    {
        
    }

  
    void FixedUpdate()
    {
        
    }

    public void HomeReturn()
    {
        Spike.spawnCntrl = 0f;
        ScoreController.Score = 0f;
        Spike.spawnRate = 4f;
        MenuPlayGame.MenuStart = true;
        Pause.controlPaused = false;
        magnet.SetActive(true);
        HighScoreConfetti.SetActive(false);
    }
}
