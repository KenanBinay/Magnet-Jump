using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
    public static float SpeedCharacter = 8f;
    public Rigidbody spike;

    void Start()
    {
        spike.useGravity = false;

    }

    void FixedUpdate()
    {    
        if (Player.Healt <= 0f)
        {
            spike.useGravity = true;
            ControllerMove.rotating = true;
            Spike.spawnCntrl = 0f;
            StartCoroutine(HealtZero());
        }
        else
        {
            if (Pause.controlPaused != true)
            {
                transform.position -= transform.forward * Time.deltaTime * SpeedCharacter;

            }
      
            spike.useGravity = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DestroyWall")) { Destroy(gameObject); }
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Player.Healt <= 0f)
            {
                SpeedCharacter = 0f;
                spike.useGravity = true;
                Spike.spawnCntrl = 0f;
                ControllerMove.rotating = true;
            }
            else if (Player.Healt >= 1f)
            {
                Destroy(gameObject);

            }
        }
    }
    private IEnumerator HealtZero()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);

    }
}
