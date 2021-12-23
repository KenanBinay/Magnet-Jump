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
                            FinalHeigh = 5.35f;
                            Speed = 1f;
                            float newScale = Mathf.Lerp(SeedHeight, FinalHeigh, Time.time * Speed);
                            transform.localScale = new Vector3(newScale, newScale, newScale);
                            StartCoroutine(HearthIncrease());
                        }
                        if (decrease)
                        {
                            FinalHeigh = 5f;
                            Speed = 1f;
                            float newScale = Mathf.Lerp(SeedHeight, FinalHeigh, Time.time * Speed);
                            transform.localScale = new Vector3(newScale, newScale, newScale);
                            if (transform.localScale == new Vector3(5f, 5f, 5f))
                            { decrease = false; }
                        }
                    }
                }
            }
        }
        if (Player.SpikeControl)
        {
            FinalHeigh = 4.70f;
            Speed = 2f;
            float newScale2 = Mathf.Lerp(SeedHeight, FinalHeigh, Time.time * Speed);
            transform.localScale = new Vector3(newScale2, newScale2, newScale2);
        }
        if (Player.healthControl)
        {

            FinalHeigh = 5.60f;
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
