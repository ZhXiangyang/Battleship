using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Tile : MonoBehaviour
{
<<<<<<< Updated upstream
    public int posX { get; set; }
    public int posY { get; set; }
    public GameObject tile;
=======
    
    //[SerializeField] public Transform tileTransform; 
    private bool ShipIsOnMe;
    
    private void Start()
    {
        
        GameManager gameManager = gameObject.GetComponent<GameManager>();
    }

    private void Update()
    {
        var transform1 = transform;
        Debug.DrawRay(transform1.position, Vector3.back, Color.red);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Ship is not on me any more");
        ShipIsOnMe = false;
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Ship is on me");
        if (other.gameObject.CompareTag("Ship"))
        {
            Debug.Log("Ship is on me");
            ShipIsOnMe = true;
        }

    }

    public void OnTileDown()
    {
        
    }

    /// <summary>
    /// If player click on tile
    /// check if there is ship or not  
    /// </summary>
    /*
    public void OnTileDown()
    {
        RaycastHit hit_info;
        
           // = Physics2D.Raycast(transform.position, Vector2.zero);
        if (Physics.Raycast(transform.position, Vector3.back , out hit_info ))
        {
            BattleShipManager target_is_a_Battleship = hit_info.transform.GetComponent<BattleShipManager>();
            SubmarineManager target_is_a_Submarine = hit_info.transform.GetComponent<SubmarineManager>();
            PatrolBoatManager target_is_a_PatrolBoat = hit_info.transform.GetComponent<PatrolBoatManager>();
            AircraftCarrierManager target_is_a_AircraftCarrier = hit_info.transform.GetComponent<AircraftCarrierManager>();
            CruiserManager target_is_a_Cruiser = hit_info.transform.GetComponent<CruiserManager>();
            

            if (target_is_a_Battleship != null)
            {
                Debug.Log("HIT BatteleShip");
                target_is_a_Battleship.ShipTakeDamage();
                
            }

            if (target_is_a_Cruiser != null)
            {
                Debug.Log("HIT Cruiser");
                target_is_a_Cruiser.ShipTakeDamage();
            }

            if (target_is_a_Submarine != null)
            {
                Debug.Log("HIT Submarine");
                target_is_a_Submarine.ShipTakeDamage();
            }

            if (target_is_a_AircraftCarrier != null)
            {
                Debug.Log("HIT AircraftCarrier");
                target_is_a_PatrolBoat.ShipTakeDamage();
            }
        }
    }*/
    
>>>>>>> Stashed changes
}
