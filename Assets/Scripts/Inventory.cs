using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {


    public int[] items;
    public Slot[] slots;
    public GameObject highlightedItem;
    public int highlightedSlot;
    public GameObject bag;
    public GameObject itemPanel;

    void Start(){
        highlightedSlot = 0;
        
    }
    

    void Update(){

        highlightedItem.transform.position =  slots[highlightedSlot].transform.position;
       itemPanel.GetComponentInChildren<Text>().text = slots[highlightedSlot].itemName;

        if (bag.GetComponent<Canvas> ().enabled == true){
            Debug.Log(slots[0].itemName);
            Debug.Log(slots[1].itemName);
            Debug.Log(slots[2].itemName);
            Debug.Log(slots[3].itemName);

            if(highlightedSlot <= slots.Length-2){

                if (Input.GetButtonDown("Right")){
                    highlightedSlot++;

                }
            }

            if(highlightedSlot >= 1 ){

                if (Input.GetButtonDown("Left")){
                    highlightedSlot--;

                }
            }

            if(highlightedSlot > 7 ){
                if (Input.GetButtonDown("Up")){
                    highlightedSlot -= 8;
                }
            }

            if(highlightedSlot <= 7  ){
                if (Input.GetButtonDown("Down")){
                    highlightedSlot += 8;
                }
            }
        }
    }

    }


