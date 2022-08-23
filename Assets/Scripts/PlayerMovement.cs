using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce, speed;
    public sbyte jumpCount = 0;
    public bool isGrounded = true;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.fwd * speed * Time.deltaTime);

        if (Input.GetKeyUp(KeyCode.Space) && isGrounded)
        {
            Jump();
        }else if(Input.GetKeyUp(KeyCode.Space) && !isGrounded && jumpCount < 2)
        {
            Jump();
        }
    }

    public void CheckForJump()
    {
        if (isGrounded)
        {
            Jump();
        }
        else if (!isGrounded && jumpCount < 2)
        {
            Jump();
        }
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce);
        isGrounded = false;
        jumpCount++;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            jumpCount = 0;
            isGrounded = true;
        }
    }
}
