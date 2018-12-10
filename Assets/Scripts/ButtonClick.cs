using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour {

    public int index;
    public string content;
    public string journal;
    //public GameObject journalTextPanel;

	// Use this for initialization
	public void SendToJournalTextPanel () {
        Debug.Log(GameObject.Find("JournalText").GetComponent<Text>().text);
		GameObject.Find("JournalText").GetComponent<Text>().text = journal;
        Debug.Log(GameObject.Find("JournalText").GetComponent<Text>().text);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
