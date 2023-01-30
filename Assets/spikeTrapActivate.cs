using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeTrapActivate : MonoBehaviour
{
    public GameObject spike;
    public GameObject enemyObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StateMachine_Robust sm = enemyObj.transform.GetComponent<StateMachine_Robust>();
        if (sm.trapActive == 1)
        {
            spike.GetComponent<Animation>().Play("spikeTrapAnim");
            sm.trapActive = 0;
            //sm.dieEnemy();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
        StateMachine_Robust sm = other.transform.GetComponent<StateMachine_Robust>();
        if (other.CompareTag("Enemy") && sm.trapActive==1)
        {
            sm.dieEnemy();
        }
    }
}
