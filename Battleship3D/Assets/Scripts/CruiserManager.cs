using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CruiserManager : MonoBehaviour
{
    //[SerializeField] private Slider Healthbar;
    private int lifepoint;

    public bool sink;
    
    // Start is called before the first frame update
    void Start()
    {
        sink = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        //Healthbar.value = lifepoint;
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
