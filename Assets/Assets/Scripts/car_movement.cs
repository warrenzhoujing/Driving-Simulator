using UnityEngine;

public class car_movement : MonoBehaviour {
    public Rigidbody rb;
    [Tooltip("Amount of force applied when going forward")]
    public float thrust;
    [Tooltip("How much rotation there will be when turning")]
    public float rotation_speed;
    [Tooltip("Maximum speed")]
    public float max_speed;
    public bool reverse = false;

    bool velocity_lock = false;
    Vector3 velocity;

	void FixedUpdate()
    {
        if (Input.GetKey("1"))
        {
            reverse = false;
        }
        if (Input.GetKey("2"))
        {
            reverse = true;
        }

        if (Input.GetKey("e"))
        {
            if (!velocity_lock)
            {
                velocity = rb.velocity;
                velocity_lock = true;
            }
            rb.velocity = velocity;
        }
        else
        {
            velocity_lock = false;
            if (Input.GetKey("w"))
            {
                if (reverse && rb.velocity.magnitude < 4)
                {
                    rb.AddForce(transform.forward * -thrust * Time.deltaTime * 0.85f, ForceMode.Impulse);
                }
                else
                {



                    if (rb.velocity.magnitude < max_speed)
                    {
                        rb.AddForce(transform.forward * thrust * Time.deltaTime, ForceMode.Impulse);
                    }


                }
            }

        }

        if (Input.GetKey("s") && rb.velocity.magnitude > 0)
        {
            rb.AddForce(transform.forward * Time.deltaTime * -rb.velocity.magnitude, ForceMode.Impulse);  
        }

        if (rb.velocity.magnitude > 0.1f)
        {
            if (Input.GetKey("a"))
            {
                transform.Rotate(Vector3.down * Time.deltaTime * rotation_speed);
            }
            if (Input.GetKey("d"))
            {
                transform.Rotate(Vector3.up * Time.deltaTime * rotation_speed);
            }   
        }

    }

}

 