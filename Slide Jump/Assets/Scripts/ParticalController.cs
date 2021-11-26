using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalController : MonoBehaviour
{
    public GameObject LwallParticle, RwallParticle, SpikeParticle,spike;
    void Start()
    {
        RwallParticle.SetActive(false);
        LwallParticle.SetActive(false);
        SpikeParticle.SetActive(false);
    }
    private void FixedUpdate()
    {
        spike = GameObject.FindGameObjectWithTag("Spike");
    }
    private void OnCollisionEnter(Collision collision)
    {
        float randX = spike.transform.position.x;

        if (collision.gameObject.CompareTag("Spike"))
        {         
            SpikeParticle.transform.position = new Vector3(randX, -2.2f, 6f);
            SpikeParticle.SetActive(true);
            StartCoroutine(Control());
        }
        if (Player.wallControlL == 1f)
        {
            LwallParticle.SetActive(true);
            RwallParticle.SetActive(false);
        }
        if (Player.wallControlR == 1f)
        {
            RwallParticle.SetActive(true);
            LwallParticle.SetActive(false);
        }
    }

   public IEnumerator Control()
    {
        yield return new WaitForSeconds(0.5f);
        SpikeParticle.SetActive(false);
    }
}
