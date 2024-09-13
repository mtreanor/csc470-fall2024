using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
    // These variables will control how the plane moves
    float forwardSpeed = 0.01f;
    float xRotationSpeed = 0.2f;
    float yRotationSpeed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get directional input (up, down, left, right)
        float hAxis = Input.GetAxis("Horizontal"); // -1 if left is pressed, 1 if right is pressed, 0 if neither
        float vAxis = Input.GetAxis("Vertical"); // -1 if down is pressed, 1 if up is pressed, 0 if neither

        // Apply the rotation based on the inputs
        transform.Rotate(vAxis * xRotationSpeed, hAxis * yRotationSpeed, 0, Space.Self);

        // Make the plane move forward by adding the forward vector to the position.
        transform.position += transform.forward * forwardSpeed;
    }


    // Unity will tell the function below to run under the following conditions:
    //  1. Two objects with colliders are colliding
    //  2. At least one of the objects' colliders are marked as "Is Trigger"
    //  3. At least one of the objects has a Rigidbody
    public void OnTriggerEnter(Collider other)
    {
        // 'other' is the name of the collider that just collided with the object
        // that this script is attached to (the plane).
        // Check to see that it has the tag "collectable". Tags are assigned in the Unity editor.
        if (other.CompareTag("collectable"))
        {
            Destroy(other.gameObject);
        }
    }
}
