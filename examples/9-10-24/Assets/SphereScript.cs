using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SphereScript : MonoBehaviour
{
    public TMP_Text scoreText;
    public Rigidbody rb;

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.useGravity = true;
        }
    }

    // Unity will tell the function below to run under the following conditions:
    //  1. Two objects with colliders are colliding
    //  2. At least one of the objects' colliders are marked as "Is Trigger"
    //  3. At least one of the objects has a Rigidbody
    public void OnTriggerEnter(Collider other)
    {
        // 'other' is the name of the collider that just collided with the object
        // that this script (the "coin") is attached to.

        // Destroy the coin!
        Destroy(other.gameObject);

        score++;
        if (score > 3)
        {
            scoreText.text = "You win!";
        } 
        else 
        {
            scoreText.text = "Score: " + score;
        }
    }

    // public void OnCollisionEnter(Collision col)
    // {
    //     Debug.Log("hit the ground!");
    // }


}
