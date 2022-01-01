using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public GameObject SpikeObject, object2, object3, ExtraHealtObject, ExtraScore;
    float Randx;
    Vector3 whereToSpawn;
    public static float spawnRate;
    public static int[] values = { 1, 2, 3 };
    int nextObject;
    public static float nextSpawn = 0.0f;
    public static float spawnCntrl = 1f;
    void Start()
    {
        spawnRate = 4f;
    }

    void FixedUpdate()
    {
        if (spawnCntrl != 0f)
        {
            if (Pause.controlPaused != true)
            {
                if (Time.time > nextSpawn)
                {
                    nextSpawn = Time.time + spawnRate;

                    Randx = Random.Range(1.81f, -3.24f);

                    whereToSpawn = new Vector3(Randx, transform.position.y, transform.position.z);

                    if (ScoreController.Score <= 100) { nextObject = values[Random.Range(0, values.Length)]; }

                    if (ScoreController.Score >= 100 && ScoreController.Score <= 200)
                    {
                        SpikeMovement.SpeedCharacter = 25;
                        if (ScoreController.Score >= 144)
                        {
                            spawnRate = 0.5f;
                        }
                        else
                        {
                            spawnRate = 1f;
                        }

                        int[] valuesM = { 1, 2, 3, 4 };
                        nextObject = valuesM[Random.Range(0, valuesM.Length)];
                    }
                    if (ScoreController.Score >= 202 && ScoreController.Score <= 402)
                    {
                        SpikeMovement.SpeedCharacter = 30;
                        spawnRate = 0.3f;
                        int[] valuesM = { 1, 2, 3, 4 };
                        nextObject = valuesM[Random.Range(0, valuesM.Length)];
                    }
                    if (ScoreController.Score >= 402 && ScoreController.Score <= 702)
                    {
                        SpikeMovement.SpeedCharacter = 40;
                        spawnRate = 0.1f;
                        int[] valuesM = { 1, 2, 3, 4 };
                        nextObject = valuesM[Random.Range(0, valuesM.Length)];
                    }
                    if (ScoreController.Score >= 702)
                    {
                        SpikeMovement.SpeedCharacter = 50;
                        spawnRate = 0.05f;
                        int[] valuesM = { 1, 2, 3, 4 };
                        nextObject = valuesM[Random.Range(0, valuesM.Length)];
                    }
                    switch (nextObject)
                    {
                        case 1:
                            Instantiate(SpikeObject, whereToSpawn, Quaternion.identity);
                            break;

                        case 2:
                            Instantiate(object2, whereToSpawn, Quaternion.identity);
                            break;

                        case 3:
                            Instantiate(object3, whereToSpawn, Quaternion.identity);
                            break;

                        case 4:
                            if (Player.Healt <= 50f)
                            {
                                Instantiate(ExtraHealtObject, whereToSpawn, Quaternion.identity);
                                Debug.Log("Health Spawn");
                            }
                            break;
                    }

                }
            }
        }
    }
}
