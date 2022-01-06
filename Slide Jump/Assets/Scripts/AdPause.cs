using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdPause : MonoBehaviour
{
    string AdID = "4461483";
    string VideoID = "Interstitial_Android";

    public static int[] values = { 1, 2, 3 };
    int nextValue;
    void Start()
    {
        Advertisement.Initialize(AdID, false);

    }

  
    public void AdGive()
    {
        nextValue = values[Random.Range(0, values.Length)];
        if (nextValue == 1)
        {
            Advertisement.Show(VideoID);
            Debug.Log("AdOn");
        }
    }
}
