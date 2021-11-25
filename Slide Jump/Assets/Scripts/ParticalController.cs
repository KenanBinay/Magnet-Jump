using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalController : MonoBehaviour
{
    public GameObject LwallParticle, RwallParticle, SpikeParticle;
    void Start()
    {
        RwallParticle.SetActive(false);
        LwallParticle.SetActive(false);
        SpikeParticle.SetActive(false);
      
    }
    private void FixedUpdate()
    {
         
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
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
