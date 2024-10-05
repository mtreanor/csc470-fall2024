using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cellPrefab;

    CellScript[,] grid;
    float spacing = 1.1f;

    float simulationTimer;
    float simulationRate = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        simulationTimer = simulationRate;

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

    public int CountNeighbors(int xIndex, int yIndex)
    {
        int count = 0;

        for (int x = xIndex - 1; x <= xIndex + 1; x++)
        {
            for (int y = yIndex - 1; y <= yIndex + 1; y++)
            {
                if (x >= 0 && x < 10 && y >= 0 && y < 10)
                {
                    if (!(x == xIndex && y == yIndex))
                    {
                        if (grid[x,y].alive)
                        {
                            count++;
                        }
                    }
                }
            }
        }

        return count;
    }

    // Update is called once per frame
    void Update()
    {
        simulationTimer -= Time.deltaTime;
        if (simulationTimer < 0) {
            if (Input.GetKey(KeyCode.Space)) {
                // Evolve our grid
                Simulate();
                simulationTimer = simulationRate;
            }
        }
    }

    void Simulate()
    {
        bool[,] nextAlive = new bool[10,10];
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                int neighborCount = CountNeighbors(x, y);
                if (grid[x,y].alive && neighborCount < 2) {
                    // underpopulation
                    nextAlive[x,y] = false;
                } else if (grid[x,y].alive && (neighborCount == 2 || neighborCount == 3)) {
                    // healthy community
                    nextAlive[x,y] = true;
                } else if (grid[x,y].alive && neighborCount > 3) {
                    // overpopulation
                    nextAlive[x,y] = false;
                } else if (!grid[x,y].alive && neighborCount == 3) {
                    // reproduction
                    nextAlive[x,y] = true;
                } else {
                    nextAlive[x,y] = grid[x,y].alive;
                }
            }
        }

        // Copy over updated values of alive
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                grid[x,y].alive = nextAlive[x,y];
                if (grid[x,y].alive) {
                    grid[x,y].aliveCount++;
                    grid[x,y].gameObject.transform.localScale = new Vector3(grid[x,y].gameObject.transform.localScale.x, 
                                                                        grid[x,y].gameObject.transform.localScale.y + .5f, 
                                                                        grid[x,y].gameObject.transform.localScale.z);
                }
                grid[x,y].SetColor();
            }
        }
    }
}
