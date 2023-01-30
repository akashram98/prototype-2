using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitTrap : MonoBehaviour
{
    public GameObject trapDoor;
    public void OnTriggerEnter(Collider other)
    {
        trapDoor.GetComponent<Animation>().Play("trapDoorAnim");
        
        if (other.CompareTag("Enemy"))
        {
            StateMachine_Robust sm = other.transform.GetComponent<StateMachine_Robust>();
            sm.dieEnemy();
        }
        if (other.CompareTag("player"))
        {
            playerMovement sm = other.transform.GetComponent<playerMovement>();
            sm.diePlayer();
        }
    }

}
