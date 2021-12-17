using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPlayGame : MonoBehaviour
{
    public Transform player;
    public GameObject PauseButton, MagnetStart;
    public RectTransform HighScoreTxt, GameEndScreen;
    [SerializeField] private AudioSource ClickSfx;

   public static bool MenuStart;
    void Start()
    {
        Player.Healt = 0f;
        MenuStart = true;
        PauseButton.SetActive(false);
        ControllerMove.rotating = true;
        ScoreController.Score = 0f;
        Spike.spawnCntrl = 0f;
        Spike.spawnRate = 0f;
        SpikeMovement.SpeedCharacter = 0f;
        player.position = new Vector3(0.32f, -2.1f, 3.952506f);
        HighScoreTxt.localScale = new Vector3(0.031f, 0.031f, 0.031f);
    }

    void FixedUpdate()
    {
       

    }

    public void PlayGame()
    {
        Debug.Log("GameStart");

        if (SFXonOff.controlSfx == false)
        {
            ClickSfx.Play();
        }

        MagnetStart.SetActive(false);
        PauseButton.SetActive(true);
        MenuStart = false;
        Player.Healt = 50f;
        Spike.spawnCntrl = 1f;
        ScoreController.Score = 0f;
        Spike.spawnRate = 4f;
        Player.SpikeControl = false;
        Pause.controlPaused = false;
        GameOverScreen.GameEnd = false;
        Pause.controlPaused = false;
        ScoreController.SfxScore = 0f;
        ScoreController.GameOverScore = 0f;
        SpikeMovement.SpeedCharacter = 8f;
        SpikeMovement.SpeedCharacter = 8f;

        player.position = new Vector3(0.32f, -2.1f, 3.952506f);
        HighScoreTxt.localScale = new Vector3(0.031f, 0.031f, 0.031f);

        Player.wallControlL = 0f;
        Player.wallControlR = 0f;
        ControllerMove.once = 0f;
  
        ControllerMove.rotating = false;
    }
}
