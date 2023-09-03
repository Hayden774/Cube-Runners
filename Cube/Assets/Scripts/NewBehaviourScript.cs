using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // remember to assign rb to whatever in unity else watch this https://www.youtube.com/watch?v=kb7rUGdGzdM
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sidewaysforce = 500f;
    

    // Update is called once per frame
    void Update()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -2f){
            FindObjectOfType<GameManager>().Gameover();
        }
    }
}
