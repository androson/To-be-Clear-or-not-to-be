using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float jumpHeight = 5;
    private float jumpDuration = 0.5f;

    // Update is called once per frame
    void Update()
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
}
