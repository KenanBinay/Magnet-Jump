using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float wallControlL, wallControlR;
    public static float Healt = 50f;
    public GameObject hitImg;
    public static bool SpikeControl,healthControl;

    void Start()
    {
        SpikeControl = false;
        hitImg.SetActive(false);
        wallControlL = wallControlR = 0f;
        Debug.Log("WallL = " + wallControlL + " || WallR = " + wallControlR);
    }
   
    void LateUpdate()
    {

        if (Healt <= 0f)
        {
            if (Pause.controlPaused)
            {

                hitImg.SetActive(true);
                ControllerMove.rotating = true;
            }
        }
        else
        {
            if (Pause.controlPaused == false)
            {

            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WallL"))
        {
            wallControlL = 1f;
            wallControlR = 0f;
            Debug.Log("WallL = " + wallControlL + " || WallR = " + wallControlR);
        }
        if (collision.gameObject.CompareTag("WallR"))
        {
            wallControlR = 1f;
            wallControlL = 0f;
            Debug.Log("WallL = " + wallControlL + " || WallR = " + wallControlR);
        }
        if (collision.gameObject.CompareTag("Spike"))
        {
            Debug.Log("Damage! Health=" + Healt);
            hitImg.SetActive(true);
            if (Healt!= 0) { Healt -= 10f; }          
            SpikeControl = true;
            StartCoroutine(HitTaken());
        }
        if (collision.gameObject.CompareTag("Health"))
        {
            Debug.Log("ExtraHeal! Health=" + Healt);
            if (Healt != 100)
            {
                Healt += 10f;
                healthControl = true;
                StartCoroutine(HealthTaken());
            }
        }
    }

    private IEnumerator HitTaken()
    {
        yield return new WaitForSeconds(0.2f);
        hitImg.SetActive(false);
        SpikeControl = false;
    }
    private IEnumerator HealthTaken()
    {
        yield return new WaitForSeconds(0.2f);
        healthControl = false;
    }
}
