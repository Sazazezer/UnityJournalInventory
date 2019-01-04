using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    [System.Serializable]
    public class DoorData
    {
        public int index;
        public int puzzleSolved;

 
        public static DoorData CreateFromJSON(string jsonString)
        {
            return JsonUtility.FromJson<DoorData>(jsonString);
        }
    }