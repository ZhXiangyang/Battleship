using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    
    public int posX { get; set; }
    public int posY { get; set; }
    public GameObject tile;

    private void Start()
    {
        
        GameManager gameManager = gameObject.GetComponent<GameManager>();
    }

    /// <summary>
    /// If player click on tile
    /// check if there is ship or not  
    /// </summary>
    public void OnMouseDown()
    {
        
    }
    
}
