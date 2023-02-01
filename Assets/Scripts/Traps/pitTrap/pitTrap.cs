using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitTrap : MonoBehaviour
{
    public GameObject trapDoor;
    public GameObject buttonPress;
    private Transform t1;

    public void OnTriggerEnter(Collider other)
    {
        
        buttonPress1 bp = buttonPress.GetComponent<buttonPress1>();
        //t1 = trapDoor.GetComponent<GameObject>().transform;
        //t1.Rotation.z = 90;
        if (other.CompareTag("Enemy") && bp.pitActive==1)
        {
            StateMachine_Robust sm = other.transform.GetComponent<StateMachine_Robust>();
            trapDoor.GetComponent<Animator>().Play("trapDoorAnim");
            trapDoor.GetComponent<Animator>().StopPlayback();
            sm.dieEnemy();
            //bp.pitActive = 0;
        }
        if (other.CompareTag("player") && (bp.pitActive == 1 || bp.pitActive==2))
        {
            playerMovement sm = other.transform.GetComponent<playerMovement>();
            sm.diePlayer();
        }
    }

}
