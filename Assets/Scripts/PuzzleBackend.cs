using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBackend : MonoBehaviour {

    public string puzzleAnswer;
    public string puzzleGuess;
    public int maxDigits;
    public bool maxDigitedSet = true;
    public int totalDigits = 10;
    

    // Use this for initialization
    void Start () {
        if (maxDigitedSet == true){
            maxDigits = puzzleAnswer.Length; 
        } else {
            maxDigits = totalDigits;
        }
        
        Debug.Log(maxDigits);
    }
    
    // Update is called once per frame
    void Update () {


    }

    public void AddNumber(int _selectedNumber){
        if (puzzleGuess.Length == maxDigits){
            Debug.Log("Nope!");
        } else {
            puzzleGuess = puzzleGuess + _selectedNumber.ToString();
            Debug.Log(puzzleGuess);               
            }

    }

    public void ClearGuess(){
        puzzleGuess = "";
    }

    public void SubmitGuess(){
        if (puzzleGuess == puzzleAnswer){
            Debug.Log("Yay.Correct.");
            ClearGuess();
        } else {
            Debug.Log("Boo. Incorrect.");
            ClearGuess();
        }
    }
}
