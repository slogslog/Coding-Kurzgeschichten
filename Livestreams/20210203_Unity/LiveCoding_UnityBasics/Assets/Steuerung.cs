using UnityEngine;

public class Steuerung : MonoBehaviour
{
    public Rigidbody rb;

    private readonly float force = 200;
    private readonly float forceSprung = 200;

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        if ( Input.GetKey(KeyCode.UpArrow) )
        {
            rb.AddForce(0, 0, force * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -force * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-force * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(force * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, forceSprung, 0);
        }
    }
}
