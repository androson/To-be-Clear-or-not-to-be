using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float jumpHeight = 5;
    [SerializeField] float jumpDuration = 0.5f;
    float horizontalInput;
    float verticalInput;
    Rigidbody rb;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        rb = GetComponent<Rigidbody>();

        PlayerMove();
    }

    void FixedUpdate()
    {
        float gravity = -2 * jumpHeight / (jumpDuration * jumpDuration);

        if (GetComponent<Rigidbody>().velocity.y < 0)
        {
            gravity *= 2;
        }

        float velocity = -gravity * jumpDuration;

        Physics.gravity = new Vector3(0, gravity, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * velocity;
        }
    }

    void PlayerMove()
    {
        rb.velocity = Vector3.forward * horizontalInput * 10f + Vector3.right * verticalInput * 10f;
    }
}
