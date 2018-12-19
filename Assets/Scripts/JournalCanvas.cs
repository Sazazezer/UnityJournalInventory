using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalCanvas : MonoBehaviour {

//    public int isActive = 0;
    public Canvas journal;
//    public Canvas bag;
//    public Text journalText;

	// Use this for initialization
	void Start () {
		
	}

    void Update(){
      //  journalText.text = "This is a test. It has passed. YAY.";
    }
	
    public void Activate(){
    //    Debug.Log("Moop");
        journal.GetComponent<Canvas> ().enabled = true;
      //  bag.GetComponent<Canvas> ().enabled = false;
        
    }

    public void Deactivate(){
    //    Debug.Log("Meep");
        journal.GetComponent<Canvas> ().enabled = false;
      //  bag.GetComponent<Canvas> ().enabled = true;
    }
}
