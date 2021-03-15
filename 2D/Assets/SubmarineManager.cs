using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarineManager : MonoBehaviour
{
    public int lifepoint;

    public bool sink;
    
    // Start is called before the first frame update
    void Start()
    {
        sink = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (sink == true)
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// If the tile raycast hits this Ship then handle its lifepoint damage
    /// </summary>
    public void ShipTakeDamage()
    {
        if (lifepoint > 0)
        {
            lifepoint--;
        }

        if (lifepoint == 0)
        {
            sink = true;
        }
    }
}
