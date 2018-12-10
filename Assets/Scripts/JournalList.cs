using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Newtonsoft.Json.Linq;

public class JournalList : MonoBehaviour {

/* 
 Look to list of journal entries, determine which has been found, and add them to the list.
 When button is clicked, displays the journal
*/
    public Button button;
    public GameObject panel;
    //private string jsonData;
    private JournalData data;
    private string filename;
    static readonly string JOURNAL_DATA = "TestEntries.json";
	// Use this for initialization
	void Start () {
       // jsonData = JsonUtility.ToJson(data);

        filename = Path.Combine(Application.streamingAssetsPath, JOURNAL_DATA);

        string jsonFromFile = File.ReadAllText(filename);

        JournalData copy = JsonUtility.FromJson<JournalData>(jsonFromFile);


        //Don't touch the stuff above. Variables go here.
        if (File.Exists(filename)){
            Instantiate(button, panel.transform);
            //button.transform.parent = panel.transform;
            button.GetComponentInChildren<Text>().text = copy.content;
            button.GetComponentInChildren<ButtonClick>().index = copy.index;
            button.GetComponentInChildren<ButtonClick>().content = copy.content;
            button.GetComponentInChildren<ButtonClick>().journal = copy.journal;
        } 
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
