using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HearthLogoAnimControll : MonoBehaviour
{
    public float SeedHeight, FinalHeigh, Speed;
    bool decrease,increase;
    void Start()
    {
       
    }
    
    void FixedUpdate()
    {
        if (MenuPlayGame.MenuStart == false)
        {
            if (Pause.controlPaused == false)
            {
                if (GameOverScreen.GameEnd == false)
                {
                    if (Player.SpikeControl == false)
                    {

                        if (decrease == false)
                        {
                            FinalHeigh = 0.22f;
                            Speed = 1f;
                            float newScale = Mathf.Lerp(SeedHeight, FinalHeigh, Time.time * Speed);
                            transform.localScale = new Vector3(newScale, newScale, newScale);
                            StartCoroutine(HearthIncrease());
                        }
                        if (decrease)
                        {
                            FinalHeigh = 0.20f;
                            Speed = 1f;
                            float newScale = Mathf.Lerp(SeedHeight, FinalHeigh, Time.time * Speed);
                            transform.localScale = new Vector3(newScale, newScale, newScale);
                            if (transform.localScale == new Vector3(0.20f, 0.20f, 0.20f))
                            { decrease = false; }
                        }
                    }
                }
            }
        }
        if (Player.SpikeControl)
        {
            FinalHeigh = 0.15f;
            Speed = 2f;
            float newScale2 = Mathf.Lerp(SeedHeight, FinalHeigh, Time.time * Speed);
            transform.localScale = new Vector3(newScale2, newScale2, newScale2);
        }
        if (Player.healthControl)
        {

            FinalHeigh = 0.25f;
            Speed = 2f;
            float newScale = Mathf.Lerp(SeedHeight, FinalHeigh, Time.time * Speed);
            transform.localScale = new Vector3(newScale, newScale, newScale);

        }

    }
    private IEnumerator HearthIncrease()
    {
        yield return new WaitForSeconds(1f);
        decrease = true;
    }
}
