using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {


    public int[] items;
    public Slot[] slots;
    

    void Update(){
        Debug.Log(slots[0].itemName);
        Debug.Log(slots[1].itemName);
        Debug.Log(slots[2].itemName);
        Debug.Log(slots[3].itemName);
    }


}
