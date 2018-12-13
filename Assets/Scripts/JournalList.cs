using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Linq;

public class JournalList : MonoBehaviour {

/* 
 Look to list of journal entries, determine which has been found, and add them to the list.
 When button is clicked, displays the journal
*/
    public Button button;
    public GameObject panel;
    private string filename;
    static readonly string JOURNAL_DATA = "TestEntries.json";
	// Use this for initialization
	void Start () {

        filename = Path.Combine(Application.streamingAssetsPath, JOURNAL_DATA);
        string jsonFromFile = File.ReadAllText(filename);
        JournalDataList list = JournalDataList.CreateFromJSON(jsonFromFile);
        if (File.Exists(filename)){
                Debug.Log("Hello?");
            for (int i = 0; i < 10; i++){
                Debug.Log("Am i alive?");
                button.GetComponentInChildren<Text>().text = list.items[i].content;
                button.GetComponentInChildren<ButtonClick>().index = list.items[i].index;
                button.GetComponentInChildren<ButtonClick>().content = list.items[i].content;
                button.GetComponentInChildren<ButtonClick>().journal = list.items[i].journal;
                Instantiate(button, panel.transform);
            }

        }
	}
}


