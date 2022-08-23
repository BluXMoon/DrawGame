using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce, speed;
    public bool canJump = true;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.fwd * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce);
    }
}
