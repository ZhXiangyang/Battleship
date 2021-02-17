using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    static int size = 10;
    Tile[,] tileTab = new Tile[size, size];

    void Start()
    {
        CreateBoard();
    }
       
    void CreateBoard()
    {

    }
}
