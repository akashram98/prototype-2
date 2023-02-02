using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proyecto26;
public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody pbody;
    public float movementSpeed = 15f;

    

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 mag = new Vector3(horizontal, 0f, vertical).normalized;

        Vector3 velocity = mag * movementSpeed * Time.deltaTime;

        pbody.MovePosition(transform.position + velocity);

        data.checkGameCompleted(data.gameCompleted);

    }
    public void diePlayer()
    {
        Destroy(gameObject, 0.4f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject,0.2f);
            data.playerDeath = "yes";
            data.endTime = System.DateTime.Now;
            data.gameCompleted = true;
            
            //data.timeToComplete = System.DateTime.Now;
            //Debug.Log(data.timeToComplete);
        }
    }
    
}
