using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float jumpHeight = 2;
    [SerializeField] float jumpDuration = 0.5f;

    float horizontalInput;
    float rotationSpeed = 0.5f;

    float verticalInput;
    float walkingSpeed = 5;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        PlayerMove();

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
        this.transform.position += Time.deltaTime * verticalInput * walkingSpeed * transform.forward;
        transform.Rotate(0, horizontalInput * rotationSpeed, 0);
    }

}
