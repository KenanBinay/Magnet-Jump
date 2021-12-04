using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public Animator OnPauseAnim;
    public GameObject PauseScreen;
    public static bool controlPaused;
    void Start()
    {
        OnPauseAnim.enabled = false;
    }

    void FixedUpdate()
    {

    }

    public void PauseGame()
    {
        ControllerMove.rotating = true;
        controlPaused = true;
        PauseScreen.SetActive(true);
        OnPauseAnim.enabled = true;
        gameObject.SetActive(false);
    }

}
