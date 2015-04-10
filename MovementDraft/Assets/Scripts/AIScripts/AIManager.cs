using UnityEngine;
using System.Collections;

public class AIManager : MonoBehaviour 
{
    private GameObject player;
    private GameObject[] enemies;
    private GameObject[] items;

    private GameObject inventoryItem;
    private Inventory inventoryScript;

    private string HEALTH = "HEALTH";

	// Use this for initialization
	void Start () 
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        items = GameObject.FindGameObjectsWithTag("PickUp");
        inventoryItem = GameObject.FindGameObjectWithTag("Inventory");
        inventoryScript = (Inventory)inventoryItem.GetComponent<Inventory>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        giveAdvice();
	}

    bool hasInInventory(string type)
    {
        if (type == HEALTH)
        {
            foreach (Slot uislot in inventoryScript.getSlotList())
            {
               // if (uislot.CurrentItem.GetType () == HealthItem.GetType())
                //{
                    return true;
                //}
            }
        }
        return false;
    }

    void giveAdvice()
    {
        PlayerModel playerModel = (PlayerModel)player.GetComponent<PlayerModel>();
        if (playerModel == null)
        {
            return;
        }
        if (playerModel.currentHealth < 50.0f)
        {
            if( hasInInventory(HEALTH) )
            {
                print("You should use a medkit! Your health is low.");
            }
            else
            {
                print(1);
                //closestHealthItem = getClosest(items, HEALTH);
                //print("You can find a health item at: "+closestHealthItem.transform.position.ToString());
            }
        }
    }
}
