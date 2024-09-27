using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cellPrefab;

    CellScript[,] grid;
    float spacing = 1.1f;

    // Start is called before the first frame update
    void Start()
    {
        grid = new CellScript[10,10];
        for (int x = 0; x < 10; x++) {
            for (int y = 0; y < 10; y++) {
                Vector3 pos = transform.position;
                pos.x += x * spacing;
                pos.z += y * spacing;
                GameObject cell = Instantiate(cellPrefab, pos, Quaternion.identity);
                grid[x,y] = cell.GetComponent<CellScript>();
                grid[x,y].alive = (Random.value > 0.5f);
                grid[x,y].xIndex = x;
                grid[x,y].yIndex = y;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
