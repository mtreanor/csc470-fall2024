using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public GameObject dominoPrefab;

    GameObject firstDomino;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 startPosition = transform.position;
        for (int i = 0; i < 50; i++) 
        {
            // Compute a position a distance based on the index.
            Vector3 position = startPosition + transform.forward * i;
            // Now use Sine to offset the position to the right (and left when Sine goes negative).
            float amplitude = 1.5f;
            float frequency = 0.5f;
            position += transform.right * amplitude * Mathf.Sin(i * frequency);

            // Make a domino at the position we just created.
            //
            // NOTE: Quaternion.identity basically says do not rotate it, but if you wanted to rotate the
            // domino you could put that here (we'll go over this later).
            GameObject domino = Instantiate(dominoPrefab, position, Quaternion.identity);

            // Get the renderer of the domino that we instantiated
            Renderer rend = domino.GetComponentInChildren<Renderer>();
            float hue = i * 0.1f;
            // If the hue goes over 1, loop back around to 0.
            hue = hue % 1f;
            rend.material.color = Color.HSVToRGB(hue, 0.4f, 1f);

            // Store a reference to the first domino so in Update() we can apply a force to knock it over
            if (i == 0) {
                firstDomino = domino;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            // "Fall over firstDomino!"
            Rigidbody rb = firstDomino.GetComponent<Rigidbody>();
            rb.AddForce(firstDomino.transform.forward * 300);
        }
    }
}
