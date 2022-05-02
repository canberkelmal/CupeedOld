using UnityEngine;

public class PlaayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float force=500f;
    public GameObject player;

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
            rb.AddForce(force*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        };
        if (Input.GetKey("a"))
        {
            rb.AddForce(-force*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        };
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, force * Time.deltaTime, ForceMode.VelocityChange);
        };
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -force * Time.deltaTime, ForceMode.VelocityChange);
        };
         if (Input.GetKey("space"))
        {
            rb.AddForce(0, force * Time.deltaTime, 0, ForceMode.VelocityChange);
        };
        

    }
}
