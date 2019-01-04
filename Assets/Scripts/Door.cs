using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public string doorAnswer;
    public bool doorMaxDigitedSet = true;
    public int doorTotalDigits = 10;
    public int doorIndex;
    public GameObject player;
    public GameObject puzzlePrefab;
    public GameObject puzzle;
    public GameObject canvas;

    public void OnTriggerEnter2D(Collider2D player){
        UseDoor();
    }

    public void UseDoor(){
        puzzle = Instantiate(puzzlePrefab,canvas.transform);
        player.GetComponent<PlayerController>().puzzle = puzzle;
        puzzle.GetComponent<PuzzleCanvas>().Activate();
        puzzle.GetComponent<PuzzleBackend>().puzzleAnswer = doorAnswer;
        puzzle.GetComponent<PuzzleBackend>().GetMaxDigits();
        puzzle.GetComponent<PuzzleBackend>().linkedObject = gameObject;
    }

    public void PuzzleUnlock () {
        puzzle.GetComponent<PuzzleCanvas>().Deactivate();
        this.GetComponent<DoorList>().UnlockPuzzleSave(doorIndex);
        Destroy(gameObject);
    }
}
