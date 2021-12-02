using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public GameObject SpikeObject,object2,object3,ExtraHealtObject,ExtraScore;
    float Randx;
    Vector3 whereToSpawn;
    public float spawnRate;
    private int[] values = { 1,2,3 };
    int nextObject;
    public static float nextSpawn = 0.0f;
    public static float spawnCntrl = 1f;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (spawnCntrl != 0f)
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;

                Randx = Random.Range(1.81f, -3.24f);

                whereToSpawn = new Vector3(Randx, transform.position.y, transform.position.z);

                if (ScoreController.Score <= 100) { nextObject = values[Random.Range(0, values.Length)]; }

                if (ScoreController.Score >= 100 && ScoreController.Score <= 400)
                {
                    SpikeMovement.SpeedCharacter = 16;
                    if (ScoreController.Score >= 144)
                    {
                        spawnRate = 2f;
                    }
                    else
                    {
                        spawnRate = 2.5f;
                    }
               
                    int[] valuesM = { 1, 2, 3, 4 };
                    nextObject = valuesM[Random.Range(0,valuesM.Length)];
                }

                switch(nextObject)
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
                        Instantiate(ExtraHealtObject, whereToSpawn, Quaternion.identity);
                        Debug.Log("Health Spawn");
                        break;
                }
            
            }
        }
    }
}
