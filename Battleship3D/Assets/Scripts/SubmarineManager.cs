using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmarineManager : MonoBehaviour
{
    
    
    //[SerializeField] private Slider Healthbar;
    
    [SerializeField] int lifepoint;

    public bool sink;

    public int LifePoint => lifepoint; 
    
    // Start is called before the first frame update
    void Start()
    {
        sink = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(lifepoint);
        //Healthbar.value = lifepoint;
        if (sink == true)
        {
            //Destroy(gameObject);
        }
        
    }

    /// <summary>
    /// If the tile raycast hits this Ship then handle its lifepoint damage
    /// </summary>
    public void ShipTakeDamage()
    {
        Debug.Log("*********************************");
        Debug.Log(lifepoint + name);
        Debug.Log("*********************************");
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
