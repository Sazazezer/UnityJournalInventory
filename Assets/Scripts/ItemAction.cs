using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Use (string _item) {

        if(_item == "Sun"){
           Debug.Log("Sun has been used"); 
        }
        if(_item == "Sword"){
           Debug.Log("Sword has been used"); 
        }
		
	}
}
