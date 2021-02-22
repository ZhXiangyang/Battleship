using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    static int size = 10;
    public GameObject prefabTile;
    public GameObject boardOrigin;
    Tile[,] tileTab = new Tile[size, size];

    void Start()
    {
        CreateBoard();
    }
       
    void CreateBoard()
    {
        
        boardOrigin.transform.position = new Vector3(-(size-1.0f) / 2, -(size-1.0f) / 2, 0);
        for (int x = 0; x < size; x++)
        {
            for (int y = 0; y< size; y++)
            {
                /*
                GameObject tile = Instantiate(prefabTile);
                tileTab[x, y] = tile.GetComponent<Tile>();
                tile.transform.SetParent(GameObject.FindWithTag("Canvas").transform, false);
                tile.transform.position = new Vector3(x, y, 0) + boardOrigin.transform.position;
                */
                GameObject tile = Instantiate(prefabTile, new Vector3(x, y, 0)+ boardOrigin.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
                tile.transform.SetParent(GameObject.FindWithTag("Canvas").transform, false);
                tile.transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }

    
    
}
