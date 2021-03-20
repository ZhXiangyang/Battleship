using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
/// <summary>
/// This class handle the tile behaviour
/// </summary>
public class Tile : MonoBehaviour
{
    
    //[SerializeField] public Transform tileTransform; 
    private bool ShipIsOnMe;

    private bool IAShipIsOnMe;
    //[SerializeField] private Material ShipIsOnMe_material;
    //[SerializeField] private GameObject CubeChildren;
    //[SerializeField]
    //private Button buttonref;
    private string Playershipname;
    private string IAshipname;
    public bool ShipIsOnMEShipIsOnME => ShipIsOnMe;

    public string Shipname => Playershipname;
    private void Start()
    {
        
    }

    private void Update()
    {
        var transform1 = transform;
        // Debug.DrawRay(transform1.position, Vector3.back, Color.red);
    }
    /// <summary>
    /// event function: check if the ship has exit the tile hitbox
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Ship is not on me any more");
        ShipIsOnMe = false;
        IAShipIsOnMe = false;
    }

    public void Changematerial()
    {
        //Debug.Log("change mat");
        //CubeChildren.GetComponent<MeshRenderer>().material = ShipIsOnMe_material;
    }
    /// <summary>
    /// event function: check if the ship has entered the tile hitbox
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        Changematerial();
    }
    /// <summary>
    /// Check if there is a ship in the hitbox and who it belong to
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Ship is on me");
        if (other.gameObject.CompareTag("Ship"))
        {
            //Debug.Log("Ship is on me");
            ShipIsOnMe = true;
            Playershipname = other.name;
        }

        if (other.gameObject.CompareTag("IAShip"))
        {
            IAShipIsOnMe = true;
            IAshipname = other.name;
        }

        
    }
    /// <summary>
    /// handle the player move:
    /// if enemy ship is on top of the tile, then it takes damage
    /// else call the playerplay() function of the gamemanager and make the ia play
    /// </summary>
    public void OnTileDown()
    {
        GameObject gameManager = GameObject.Find("GameManager");
        if (IAShipIsOnMe)
        {
            Debug.Log("IASHIP IS ON ME");
            Debug.Log(name);
            gameManager.GetComponent<GameManager>().PlayerPlay(name, IAShipIsOnMe);
            Debug.Log("name of ship: "+IAshipname);
            TakeDamage(IAshipname);
            
        }
        else
        {
            gameManager.GetComponent<GameManager>().PlayerPlay(name, IAShipIsOnMe);
            gameManager.GetComponent<GameManager>().IAPlay(); 
        }
    }
    /// <summary>
    /// deal damage to the ship
    /// </summary>
    /// <param name="name"></param>
    public void TakeDamage(string name)
    {
        Debug.Log("name of ship"+ name);
        GameObject Ship = GameObject.Find(name);
    
        PatrolBoatManager Patrolboat = Ship.GetComponent<PatrolBoatManager>();
        CruiserManager cruiserManager = Ship.GetComponent<CruiserManager>();
        AircraftCarrierManager aircraftship = Ship.GetComponent<AircraftCarrierManager>();
        SubmarineManager submarineManager = Ship.GetComponent<SubmarineManager>();
        BattleShipManager battleShipManager = Ship.GetComponent<BattleShipManager>();

        if (Patrolboat != null)
        {
            Patrolboat.ShipTakeDamage();
        }
        if (cruiserManager != null)
        {
            cruiserManager.ShipTakeDamage();
        }
        if (aircraftship != null)
        {
            aircraftship.ShipTakeDamage();
        }
        if (submarineManager != null)
        {
            submarineManager.ShipTakeDamage();
        }
        if (battleShipManager != null)
        {
            battleShipManager.ShipTakeDamage();
        }

        
    }
    
    
    
    
}
