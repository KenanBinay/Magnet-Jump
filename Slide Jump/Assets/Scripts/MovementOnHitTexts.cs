using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOnHitTexts : MonoBehaviour
{
    public static float SpeedText = 1.5f;
    void Start()
    {

    }

    void FixedUpdate()
    {
        transform.position += transform.up * Time.deltaTime * SpeedText;
        StartCoroutine(endText());
    }
    private IEnumerator endText()
    {
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Text Refreshed");
        Destroy(gameObject);
    }
}
