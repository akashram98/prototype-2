using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitTrap : MonoBehaviour
{
    public GameObject trapDoor;
    public GameObject buttonPress;

    public void OnTriggerEnter(Collider other)
    {
        
        buttonPress1 bp = buttonPress.GetComponent<buttonPress1>();
        if (other.CompareTag("Enemy") && bp.pitActive==1)
        {
            StateMachine_Robust sm = other.transform.GetComponent<StateMachine_Robust>();
            trapDoor.GetComponent<Animation>().Play("trapDoorAnim");
            sm.dieEnemy();
            bp.pitActive = 0;
        }
        if (other.CompareTag("player"))
        {
            playerMovement sm = other.transform.GetComponent<playerMovement>();
            sm.diePlayer();
        }
    }

}
