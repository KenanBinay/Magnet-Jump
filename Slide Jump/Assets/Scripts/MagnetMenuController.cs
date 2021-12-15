using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetMenuController : MonoBehaviour
{
    public float degreesPerSecond;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(1f, 1f, 1f) * degreesPerSecond * Time.deltaTime);
    }
}
