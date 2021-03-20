using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    [SerializeField] private GameObject Aircraftcarrier;
    [SerializeField] private GameObject BattleShip;
    [SerializeField] private GameObject Cruiser;
    [SerializeField] private GameObject PatrolBoat;
    [SerializeField] private GameObject Submarine;

    
    // Start is called before the first frame update
    public void Startclick()
    {
        Aircraftcarrier.GetComponent<Image>().raycastTarget = false;
        BattleShip.GetComponent<Image>().raycastTarget = false;
        Cruiser.GetComponent<Image>().raycastTarget = false;
        PatrolBoat.GetComponent<Image>().raycastTarget = false;
        Submarine.GetComponent<Image>().raycastTarget = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
