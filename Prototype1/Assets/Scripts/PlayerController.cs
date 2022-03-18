using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private variables
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //These is were  we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        
        //

        //EXTRA CODES
        //transform.Translate(0, 0, 1);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);



        //We move the vehicle forward
        if (Input.GetKey("w") || Input.GetKey("s"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        }
        //We turn the vehicle
        if (Input.GetKey("d") || Input.GetKey("a"))
        {
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
          
        }
      


    }
}
