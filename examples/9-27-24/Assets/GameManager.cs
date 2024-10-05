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

        // Instantiate a grid of cells
        grid = new CellScript[10,10];
        for (int x = 0; x < 10; x++) {
            for (int y = 0; y < 10; y++) {
                // Use the x, y interator variables to compute each cell's position. If this is confusing
                // to you, try thinking about instantiating a row of cells rather than a grid, and using
                // the iterator variable of a single for loop to compute the position.
                Vector3 pos = transform.position;
                pos.x += x * spacing;
                pos.z += y * spacing;
                GameObject cell = Instantiate(cellPrefab, pos, Quaternion.identity);
                grid[x,y] = cell.GetComponent<CellScript>();
                grid[x,y].alive = (Random.value > 0.5f); // Assign random true or false to the alive of the cell.
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
                // This if prevents us from indexing the two dimensional array out of bounds
                if (x >= 0 && x < 10 && y >= 0 && y < 10)
                {
                    // This if makes sure we don't consider the cell itself while counting its
                    // neighbors
                    if (!(x == xIndex && y == yIndex))
                    {
                        // If one of the surrounding cells is alive, increment the alive count.
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
        // This if statement will fire ever "simulationRate" amount of time. This is
        // called the "timer pattern" and you should use something like it whenever you
        // want to have timed events that happen at a cinsistent rhythm.
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
                // Update the cell's alive value based on Conway's Game of Life rules. Note, that we 
                // don't directly update the grid, as we don't want subsequent cells being updated to
                // take into account the updated alive value. Once we've updated all cells in nextAlive
                // we will copy the alive values back into the cells in the grid.
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
                // Copy over the updated value
                grid[x,y].alive = nextAlive[x,y];

                // Below is an example of some interesting things you can do based on the updated value
                if (grid[x,y].alive) {
                    // Increment how many times the cell has ever been alive (we use this in SetColor to have
                    // the cell's color based on how many times it has been alive).
                    grid[x,y].aliveCount++;

                    // Make it so that we make the cell a little taller every time it is alive.
                    grid[x,y].gameObject.transform.localScale = new Vector3(grid[x,y].gameObject.transform.localScale.x, 
                                                                        grid[x,y].gameObject.transform.localScale.y + .5f, 
                                                                        grid[x,y].gameObject.transform.localScale.z);
                }

                // Call SetColor which will deal with setting the color based on the specific cell's data (alive/aliveCount)
                grid[x,y].SetColor();
            }
        }
    }
}
