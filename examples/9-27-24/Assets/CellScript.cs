using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellScript : MonoBehaviour
{
    public Renderer cubeRenderer;

    public bool alive = false;

    public int xIndex = -1;
    public int yIndex = -1;

    public Color aliveColor;
    public Color deadColor;

    // Start is called before the first frame update
    void Start()
    {
        SetColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        alive = !alive;
        SetColor();
    }
    void SetColor() {
        if (alive) {
            cubeRenderer.material.color = aliveColor;
        } else {
            cubeRenderer.material.color = deadColor;
        }
    }
}
