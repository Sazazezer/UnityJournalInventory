using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnTree : MonoBehaviour {

    public int canBurn = 0;
    public GameObject treeInQuestion;
    public string keyInHand;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void Update(){
                Debug.Log(canBurn);
        if(canBurn > 0){
            canBurn--;
        }
    }

}
