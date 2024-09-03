using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // turn gravity on!
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;
        }
    }
}
