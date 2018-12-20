using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAction : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	public void Use (string _item) {

        if(_item == "Sun"){
           Debug.Log("Sun has been used"); 

           player.GetComponent<BurnTree>().canBurn= 100 ;
        }
        if(_item == "Sword"){
           Debug.Log("Sword has been used"); 
        }
		
	}
}
