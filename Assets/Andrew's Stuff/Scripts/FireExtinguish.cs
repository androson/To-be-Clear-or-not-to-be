using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "MediumFlames")
        {
            Destroy(other.gameObject);
        }
    }
}
