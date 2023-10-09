using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    float rotationSpeed = 0.6f;

    float verticalInput;
    float walkingSpeed = 5;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        PlayerMove();
    }

    void PlayerMove()
    {
        this.transform.position += Time.deltaTime * verticalInput * walkingSpeed * transform.forward;
        transform.Rotate(0, horizontalInput * rotationSpeed, 0);
    }

}
