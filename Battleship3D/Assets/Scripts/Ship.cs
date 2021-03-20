using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    
    //private int size;
    private bool sink;
    public (float, float) pos = (0.0f, 0.0f);
    public int Health;
    
    // Start is called before the first frame update
    void Start()
    {
        sink = false;
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            sink = true;
            Destroy(this);
        }
    }
    
    

}
