using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    private Transform player;
    private Inventory inventory;
    public GameObject explosionEffect;
    public int slotNumber;
    public GameObject actionObject;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public void Use(string _use) {
        Debug.Log("Boop");
        Instantiate(explosionEffect, player.transform.position, Quaternion.identity);
        actionObject.GetComponent<ItemAction>().Use(_use);
        inventory.slots[slotNumber].itemName = "";
        inventory.slots[slotNumber].itemDescription = "";
        Destroy(gameObject);
    }


}
