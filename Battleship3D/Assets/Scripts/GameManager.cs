using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    [SerializeField] private Slider Playerhealthbar;
    private int playerlife = 20;
    [SerializeField] private Slider IAhealthbar;
    private int IAlife = 20;
    private int Switchplayer = 0;
    private int initializer = 0;
    Queue<string> TileNamesIA_Queue = new Queue<string>();
    [FormerlySerializedAs("Tile Miss Image")] [SerializeField] private Sprite tileusedImage;

    [SerializeField] private Sprite tileusedPLAYERImage;
    [FormerlySerializedAs("Tile Hit Image")] [SerializeField] private Sprite tilehitPLAYERImage;
    [SerializeField] private Sprite tilehitIAImage;
    [FormerlySerializedAs("Instruction Text Mesh Pro")] [SerializeField] 
    private TextMeshProUGUI textInstruction;

    [SerializeField] private AudioSource Explosionsound;
    
    void Start()
    {
        Playerhealthbar.maxValue = playerlife;
        Playerhealthbar.value = playerlife;
        IAhealthbar.maxValue = IAlife;
        Playerhealthbar.value = IAlife;

    }

    void Update()
    {
        Playerhealthbar.value = playerlife;
        IAhealthbar.value = IAlife;
        Debug.Log(IAlife);
        if (IAlife == 0 || playerlife ==0)//gameover
        {
            Invoke("Restart",4f);
        }
    }
    
    /// <summary>
    /// check if the click of the player has touched enemy ship !
    /// if the player hit something then play sound and change the tile appearance
    /// else juste change tile appeareace as "missed"
    /// </summary>
    public void PlayerPlay(string name, bool hitsomething)
    {
        GameObject tile;
        tile = GameObject.Find(name);
        if (hitsomething)
        {
            Explosionsound.Play();
            SetTileTouched(tile);
            IAlife--;
        }
        else
        {
            SetTileMissed(tile, true);
        }
        
    }
    /// <summary>
    /// Get a random Tile and check if player's ship is there
    /// and change its appearance whether player ship is here or not
    /// </summary>
    public void IAPlay()
    {
        int TileNumber;
        string TileName = "";
        //string[] TileNamearrayIA = new string[100];
        if (initializer < 100)
        {
            if (initializer == 0)
            {
                TileNamesIA_Queue.Enqueue(TileName);
                //initializer++;
                TileNumber = Random.Range(0, 100);
                TileName = string.Format("TileUI ({0})", TileNumber);
            }

            do // Make sure the tile has already been used
            {
                TileNumber = Random.Range(0, 100);
                TileName = string.Format("TileUI ({0})", TileNumber);
                //Debug.Log("ALREADY USED WHILE" + TileName);
            } while (TileNamesIA_Queue.Contains(TileName));
            
        
        
            TileNamesIA_Queue.Enqueue(TileName);
            //Debug.Log("ALREADY USED"+ TileNamesIA_Queue.Contains(TileName));
            //Debug.Log("TileName:" + TileName);
            GameObject tile;
            tile = GameObject.Find(TileName);

            Tile TileManager = tile.GetComponent<Tile>();
            //tile.GetComponent<Image>().sprite = tileusedImage;

            if (TileManager.ShipIsOnMEShipIsOnME)
            {
                //Debug.Log("IA Shot one of Player's Ship ! on tile:" + TileName);
                //tile.GetComponent<Image>().sprite = tileusedImage; 
                SetTileTouched(tile);
                TileManager.TakeDamage(TileManager.Shipname);
                playerlife--;
                Explosionsound.Play();
                //tile.GetComponent<RectTransform>().;
                //tile.GetComponent<MeshRenderer>().sortingOrder = 1;
            }
            else
            {
                //Debug.Log("IA Shot NOTHING ! on tile:" + TileName);
                SetTileMissed(tile);
            }
            initializer++;
        }

        
    }
    /// <summary>
    /// Just change the sprite of the tile when touched
    /// </summary>
    /// <param name="tile"></param>
    private void SetTileTouched(GameObject tile)
    {
        tile.GetComponent<Image>().sprite = tilehitIAImage;
    }
    private void SetTileTouched(GameObject tile, bool player)
    {
        if (player)
        {
            tile.GetComponent<Image>().sprite = tilehitPLAYERImage;
        }
        
    }
    /// <summary>
    /// Just change the sprite of the tile when missed
    /// </summary>
    /// <param name="tile"></param>
    private void SetTileMissed(GameObject tile)
    {
        if (tile.GetComponent<Image>().sprite == tileusedPLAYERImage)
        {
            tile.GetComponent<Image>().sprite = tileusedPLAYERImage;
        }
        tile.GetComponent<Image>().sprite = tileusedImage;
    }
    private void SetTileMissed(GameObject tile, bool player)
    {
        if (player)
        {
            tile.GetComponent<Image>().sprite = tileusedPLAYERImage;
        }
        
    }
    
    /// <summary>
    /// (not used)
    /// print the game status but actually the game is quite fast ! so useless
    /// </summary>
    private void Printiaturn()
    {
        textInstruction.text = "Your enemi is playing";
    }

    private void PrintPlayerturn()
    {
        textInstruction.text = "Time to make a move ! ";
    }
    private void OnMouseDown()
    {
        
    }

    void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
