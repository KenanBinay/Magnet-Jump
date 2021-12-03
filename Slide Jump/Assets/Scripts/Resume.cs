using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject PauseButton, PauseScreen;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void ResumeButton()
    {
        PauseButton.SetActive(true);
        PauseScreen.SetActive(false);
    }
}
