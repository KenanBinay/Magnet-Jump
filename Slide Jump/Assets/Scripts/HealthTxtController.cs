using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthTxtController : MonoBehaviour
{
    public GameObject HealthPrefab;
    public TMPro.TextMeshPro healthTxt;
    void Start()
    {
    
    }

  
    void FixedUpdate()
    {
        healthTxt.text = Player.Healt.ToString();
    }
}
