using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Color;

public class AircraftCarrierManager : MonoBehaviour
{
    //[SerializeField] private Slider Healthbar;
    private int lifepoint = 5;

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
            //Destroy(gameObject);
        }

        //Healthbar.value = lifepoint;
    }

    /// <summary>
    /// If the tile raycast hits this Ship then handle its lifepoint damage
    /// </summary>
    public void ShipTakeDamage()
    {
        Debug.Log("*********************************");
        Debug.Log(lifepoint + name + tag);
        Debug.Log("*********************************");
        if (lifepoint > 0)
        {
            lifepoint--;
        }

        if (lifepoint == 0)
        {
            sink = true;
        }
        Debug.Log(lifepoint);
    }
}
