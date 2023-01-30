using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress1 : MonoBehaviour
{
    public float pitActive = 0;
    public GameObject buttonP;
    public GameObject enemyObj;
    public void OnTriggerEnter(Collider other)
    {
        buttonP.GetComponent<Animation>().Play("buttonAnim1");
        
        pitActive = 1;
        Destroy(gameObject);

    }
}
