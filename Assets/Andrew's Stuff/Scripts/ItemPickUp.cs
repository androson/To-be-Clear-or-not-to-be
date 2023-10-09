using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{

    Vector3 offset = new Vector3(1, 0, -0.2f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Item") && Input.GetKeyDown(KeyCode.F))
        {
            other.transform.position = transform.position + offset;
        }
    }
}
