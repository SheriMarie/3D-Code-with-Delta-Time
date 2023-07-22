using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

   

    void Update()
    {
        // Jump movement (working)

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody playerRB = GetComponent<Rigidbody>();
            playerRB.AddForce(transform.up * 200f);
        }

        // Forward (working)

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Rigidbody playerRB = GetComponent<Rigidbody>();
            playerRB.AddForce(transform.forward * 20000f * Time.deltaTime);
        }

        //Attempting left movement (working)

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Rigidbody playerRB = GetComponent<Rigidbody>();
            playerRB.AddForce(Vector3.left * 20000f * Time.deltaTime);
        }

        //Attempting right movement (working)

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Rigidbody playerRB = GetComponent<Rigidbody>();
            playerRB.AddForce(Vector3.right * 20000f * Time.deltaTime);
        }

        //Attempting back movement (working)

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Rigidbody playerRB = GetComponent<Rigidbody>();
            playerRB.AddForce(Vector3.back * 20000f * Time.deltaTime);
        }
    }
    
}

// Now work out how to use delta time when moving left and right  //Time.deltaTime; 