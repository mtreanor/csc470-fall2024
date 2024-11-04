using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour
{
    public string unitName;
    public string bio;
    public string stats;

    public Renderer bodyRenderer;
    public Color normalColor;
    public Color selectedColor;
    public bool selected = false;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.units.Add(this);

        transform.Rotate(0, Random.Range(0, 360), 0);
    }

    void OnDestroy()
    {
        GameManager.instance.units.Remove(this);
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        // GameObject gmObj = GameObject.Find("GameManagerObject");
        // GameManager gm = gmObj.GetComponent<GameManager>();

        GameManager.instance.SelectUnit(this);
    }
}
