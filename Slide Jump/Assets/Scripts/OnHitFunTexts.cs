using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnHitFunTexts : MonoBehaviour
{
    public GameObject text1, text2, text3, text4, text5, spawnPoint, health1, health2;
    float randX;
    private int[] values = { 1, 2, 3, 4, 5 };
    int nextText;
    Vector3 whereToSpawn, whereToSpawn2;

    private int[] valuesForHealt = { 1, 2 };
    int nextHealth;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            nextText = values[Random.Range(0, values.Length)];
            randX = Random.Range(-3.2f, 4f);
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
        if (collision.gameObject.CompareTag("Health"))
        {
            if (Player.Healt >= 1f&&Player.Healt!=100f)
            {
                nextHealth = values[Random.Range(0, valuesForHealt.Length)];
                whereToSpawn = new Vector3(2.1f, 18.502f, 70.113f);
                whereToSpawn2 = new Vector3(4f, 19f, 70f);
                Debug.Log("HealthEarnedShow = " + nextHealth);

                switch (nextHealth)
                {
                    case 1:
                        Debug.Log("Health1 spawned");
                        Instantiate(health1, whereToSpawn, Quaternion.identity);
                        break;

                    case 2:
                        Debug.Log("Health2 spawned");
                        Instantiate(health2, whereToSpawn2, Quaternion.identity);
                        break;
                }
            }
        }
    }
}