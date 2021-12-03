using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float wallControlL, wallControlR;
    public static float Healt = 100f;
    public GameObject hitImg;
    public static bool SpikeControl;

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
            hitImg.SetActive(true);
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
            if(Healt!=100)
            Healt += 10f;
        }
    }

    private IEnumerator HitTaken()
    {
        yield return new WaitForSeconds(0.2f);
        hitImg.SetActive(false);
        SpikeControl = false;
    }
}
