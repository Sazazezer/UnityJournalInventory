using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    private Inventory inventory;
    public GameObject itemButton;
    public GameObject effect;
    public GameObject instance;
    public string quickDescription;
    public string description;
    public string uniqueKey;
    public bool indestructable = false;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            // spawn the sun button at the first available inventory slot ! 
            

            for (int i = 0; i < inventory.items.Length; i++)
            {
                if (inventory.items[i] == 0) { // check whether the slot is EMPTY
                    Instantiate(effect, transform.position, Quaternion.identity);
                    inventory.items[i] = 1; // makes sure that the slot is now considered FULL
                    instance = Instantiate(itemButton, inventory.slots[i].transform, false); // spawn the button so that the player can interact with it
                    inventory.slots[i].itemName = quickDescription;
                    inventory.slots[i].itemDescription = description;
                    inventory.slots[i].itemObject = instance;
                    inventory.slots[i].KeyID = uniqueKey;
                    inventory.slots[i].itemIndestructible = indestructable;
                    instance.GetComponent<Item>().slotNumber = i;
                    Destroy(gameObject);
                    break;
                }
            }
        }
        
    }
}
