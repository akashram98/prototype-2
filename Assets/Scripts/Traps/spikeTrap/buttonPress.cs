using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress : MonoBehaviour
{

    public float spikeActive = 0;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            if (spikeActive == 0)
            {
                GetComponent<Animation>().Play("buttonAnim");
                spikeActive = 1;
            }
            //Destroy(gameObject);
            StartCoroutine(waitFunc());
        }
        
    }
    IEnumerator waitFunc()
    {
        yield return new WaitForSeconds(1.5f);
        spikeActive = 2;

    }
}
