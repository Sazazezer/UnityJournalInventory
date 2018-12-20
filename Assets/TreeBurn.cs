﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeBurn : MonoBehaviour {

    public bool isBurning = false;
    public GameObject player;
    public string lockNumber;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (isBurning==true){
            Debug.Log("Noooo");
            Destroy(gameObject);
        }
		
	}

     private void OnTriggerEnter2D(Collider2D other){

        if (other.tag == "Player" && player.GetComponent<BurnTree>().canBurn > 0){  
            if (player.GetComponent<BurnTree>().keyInHand == lockNumber){ 
                Debug.Log("Burning");
                isBurning=true;
            }
        }
    }
}
        