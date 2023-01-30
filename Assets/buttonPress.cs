using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress : MonoBehaviour
{
    
    public GameObject buttonP;
    public GameObject enemyObj;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            buttonP.GetComponent<Animation>().Play("buttonAnim");
            StateMachine_Robust sm = enemyObj.transform.GetComponent<StateMachine_Robust>();
            sm.trapActive = 1;
        }
        
    }
}
