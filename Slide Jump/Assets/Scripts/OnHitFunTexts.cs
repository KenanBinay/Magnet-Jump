using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnHitFunTexts : MonoBehaviour
{
    public GameObject text1, text2, text3, text4, text5,spawnPoint;
    float randX;
    private int[] values = { 1, 2, 3, 4, 5 };
    int nextText; 
    Vector3 whereToSpawn;

    void Start()
    {

    }

    void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            nextText = values[Random.Range(0, values.Length)];
            randX = Random.Range(-3.2f,4f);
            whereToSpawn = new Vector3(randX, spawnPoint.transform.position.y, spawnPoint.transform.position.z);
            Debug.Log("Text = " + nextText);

            switch (nextText)
            {
                case 1:
                    Debug.Log("text1 spawned");
                    Instantiate(text1, whereToSpawn, Quaternion.identity);           
                    break;

                case 2:
                    Debug.Log("text2 spawned");
                    Instantiate(text2, whereToSpawn, Quaternion.identity);
                    break;

                case 3:
                    Debug.Log("text3 spawned");
                    Instantiate(text3, whereToSpawn, Quaternion.identity);               
                    break;

                case 4:
                    Debug.Log("text4 spawned");
                    Instantiate(text4, whereToSpawn, Quaternion.identity);             
                    break;

                case 5:
                    Debug.Log("text5 spawned");
                    Instantiate(text5, whereToSpawn, Quaternion.identity);    
                    break;
            }
               
        }
    }
}