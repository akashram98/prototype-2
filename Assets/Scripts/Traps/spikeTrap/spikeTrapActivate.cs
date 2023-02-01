using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeTrapActivate : MonoBehaviour
{
    public GameObject button;
    private float counter = 0;
    // Update is called once per frame
    void Update()
    {
        buttonPress bp = button.GetComponent<buttonPress>();
        if (bp.spikeActive==1 && counter==0)
        {
            GetComponent<Animation>().Play("spikeTrapAnim");
            //sm.trapActive = 0;
            //sm.dieEnemy();
            counter = 1;
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        buttonPress bp = button.GetComponent<buttonPress>();
        StateMachine_Robust sm = other.transform.GetComponent<StateMachine_Robust>();
        if (other.CompareTag("Enemy") && bp.spikeActive==1)
        {
            sm.dieEnemy();
        }
    }
}
