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
    private string jsonData;
   // public GameObject parentPanel;
   // private GameObject destroyButton;
    private string filename;
    static readonly string JOURNAL_DATA = "TestEntries.json";
	// Use this for initialization
	void Start () {
        filename = Path.Combine(Application.streamingAssetsPath, JOURNAL_DATA);
        JournalCompile();
	}

    public void JournalCompile(){
        Debug.Log("Recompiling Journal");
        foreach (Transform child in transform) {
            GameObject.Destroy(child.gameObject);
        }

        
        string jsonFromFile = File.ReadAllText(filename);
        JournalDataList list = JournalDataList.CreateFromJSON(jsonFromFile);

        if (File.Exists(filename)){

            for (int i = 0; i < 5; i++){ //i should probably fix the counter at some point...
                if (list.items[i].lockedAway == 1){
                    button.GetComponentInChildren<Text>().text = list.items[i].content;
                    button.GetComponentInChildren<ButtonClick>().index = list.items[i].index;
                    button.GetComponentInChildren<ButtonClick>().content = list.items[i].content;
                    button.GetComponentInChildren<ButtonClick>().journal = list.items[i].journal;
                    Instantiate(button, panel.transform);
                }
            }
        }
        Debug.Log("Finished Compiling Journal");

    }

    public void AddNewJournal(int _newIndex){
        Debug.Log("Starting Pickup");
        string jsonFromFile = File.ReadAllText(filename);
        JournalDataList list = JournalDataList.CreateFromJSON(jsonFromFile);
        int newIndex = _newIndex;
        list.items[newIndex].lockedAway = 1;
        jsonData = JsonUtility.ToJson(list);

            if (File.Exists(filename)){
                File.Delete(filename);
            }

            File.WriteAllText(filename, jsonData);
            Debug.Log("Completed Pickup");
            JournalCompile();
    }
}


