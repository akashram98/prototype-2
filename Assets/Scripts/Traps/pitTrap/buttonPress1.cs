using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress1 : MonoBehaviour
{
    public float pitActive = 0;
    //public GameObject buttonP;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            //buttonP.GetComponent<Animator>().wrapMode = WrapMode.Once;
            GetComponent<Animator>().Play("buttonAnim1");
            GetComponent<Animator>().StopPlayback();
            if (pitActive == 0)
            {
                pitActive = 1;
            }
            Debug.Log("start");
            //Destroy(gameObject);
            StartCoroutine(waitFunc());
            
        }

        
    }
    IEnumerator waitFunc()
    {
        yield return new WaitForSeconds(1.5f);
        pitActive = 2;
        Debug.Log("stop");
        
    }
    
}
