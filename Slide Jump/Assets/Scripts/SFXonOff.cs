using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXonOff : MonoBehaviour
{
    public GameObject muteStick;
    public static float controlSfx; 
    void Start()
    {
       muteStick.SetActive(false);
    }

    
    void FixedUpdate()
    {
        
    }

    public void SfxControll()
    {
        if (controlSfx == 0f)
        {
            Debug.Log("Mute On");

            muteStick.SetActive(true);
            controlSfx = 1f;
        }
        else if(controlSfx == 1f)
        {
            Debug.Log("Mute Off");

            muteStick.SetActive(false);
            controlSfx = 0f;
        }
        
    }
}
