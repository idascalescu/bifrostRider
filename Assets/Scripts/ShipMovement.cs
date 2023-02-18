using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    Rigidbody rb;
    //Variables
    [SerializeField]
    float forceMag;
    [SerializeField]
    float steerSpeed;
    [SerializeField]
    float reverseSpeed;

    float smooth = 5.0f;
    float tiltAngle = 33.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    private void Update()
    {
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;// Smoothly tilts a transform towards a target rotation.
        Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);// Rotate the cube by converting the angles into a quaternion.
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);// Dampen towards the target rotation
        
        if (Input.GetKeyDown(KeyCode.Escape))//when escape is pressed the application will shut
        {
            Debug.Log("Good Bye");
            Application.Quit();
        }
    }
    private void FixedUpdate()
    {
        Vector3 totalForce = new Vector3();

        if(Input.GetKey("w"))
        {
            totalForce = new Vector3(0.0f, 0.0f, forceMag);
        }
        if (Input.GetKey("a"))
        {
            totalForce = new Vector3(-steerSpeed, 0.0f, 0.0f);
        }
        if (Input.GetKey("s"))
        {
            totalForce = new Vector3(0.0f, 0.0f, -reverseSpeed);
        }
        if (Input.GetKey("d"))
        {
            totalForce = new Vector3(steerSpeed, 0.0f, 0.0f);
        }
        rb.AddForce(totalForce, ForceMode.Force);
    }
}
