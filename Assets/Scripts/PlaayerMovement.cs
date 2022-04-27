using UnityEngine;

public class PlaayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 500f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        rb.useGravity=true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0,0,forwardForce*Time.deltaTime);

        if (Input.GetKey("d")){        
            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        };
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        };
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        };
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        };

    }
}
