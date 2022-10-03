using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidMovement : MonoBehaviour
{
    public Rigidbody rb;

    public Joystick joystick;

    public float forwardForce;
    public float upwardForce;
    public float sidewaysForce;

    bool grounded = true;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }

    // Update is called once per frame
    void Update ()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if ( joystick.Vertical >= 0.5f && grounded)
        {
            rb.AddForce(0, upwardForce * Time.fixedDeltaTime, 0, ForceMode.VelocityChange);
            grounded = false;
        }
        
        if (joystick.Horizontal >= 0.2f)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (joystick.Horizontal <= -0.2f)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else
        {
            rb.AddForce(0, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
