using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeTrapActivate : MonoBehaviour
{
    public GameObject button;
    public GameObject spikeTrap;
    private float counter = 0;
    // Update is called once per frame
    void Update()
    {
        buttonPress bp = button.GetComponent<buttonPress>();
        if (bp.spikeActive==1 && counter==0)
        {
            spikeTrap.GetComponent<Animation>().Play("spikeTrapAnim");
            //sm.trapActive = 0;
            //sm.dieEnemy();
            counter = 1;
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        buttonPress bp = button.GetComponent<buttonPress>();
        
        if (other.CompareTag("Enemy") && bp.spikeActive == 1)
        {
            //Destroy(other, 0.5f);
            StateMachine_Robust sm3 = other.transform.GetComponent<StateMachine_Robust>();
            StartCoroutine(sm3.dieEnemy());
            
            
            //StateMachine_Robust sm1 = other.transform.GetComponent<StateMachine_Robust>();
            //sm1.dieEnemy();
        }
    }
}
