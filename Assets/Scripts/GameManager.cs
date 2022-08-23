using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Jump()
    {
        FindObjectOfType<PlayerMovement>().CheckForJump();
    }
}
