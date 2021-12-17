using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXonOff : MonoBehaviour
{
    public GameObject muteStick;
    public static bool controlSfx;
    [SerializeField] private AudioSource ClickSfx;
    void Start()
    {
        muteStick.SetActive(false);
    
    }

    
    void FixedUpdate()
    {
        
    }

    public void SfxControll()
    {
        if (controlSfx == false)
        {
            Debug.Log("Mute On");
            muteStick.SetActive(true);
            controlSfx = true;
        }
        else if(controlSfx)
        {
            Debug.Log("Mute Off");

            ClickSfx.Play();
            muteStick.SetActive(false);
            controlSfx = false;
        }
        
    }
}
