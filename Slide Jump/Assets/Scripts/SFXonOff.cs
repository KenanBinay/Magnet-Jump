using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXonOff : MonoBehaviour
{
    public GameObject muteStick;
    public static bool controlSfx; 
    void Start()
    {
       muteStick.SetActive(false);
        controlSfx = true;
    }

    
    void FixedUpdate()
    {
        
    }

    public void SfxControll()
    {
        if (controlSfx)
        {
            Debug.Log("Mute On");

            muteStick.SetActive(true);
            controlSfx = false;
        }
        else if(controlSfx == false)
        {
            Debug.Log("Mute Off");

            muteStick.SetActive(false);
            controlSfx = true;
        }
        
    }
}
