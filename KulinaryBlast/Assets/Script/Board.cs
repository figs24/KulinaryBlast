using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    public int width;
    public int height;
    private BackgroundTile[,] allTiles;
    public GameObject tilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        allTiles = new BackgroundTile[width, height];
        SetUp();


    }
    public void SetUp()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector3 tempPosition = new Vector3(x, y);
                GameObject backgroundTile = Instantiate(tilePrefab, tempPosition, Quaternion.identity);
                backgroundTile.transform.parent = this.transform;
                backgroundTile.name = "(" + x + "," + y + ")";
            }
        }

    }
}