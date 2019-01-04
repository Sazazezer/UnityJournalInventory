using UnityEngine;
using System.Collections;
using System.Collections.Generic;

    [System.Serializable]
    public class DoorDataList
    {
        public DoorData[] items;
 
        public static DoorDataList CreateFromJSON(string jsonString)
        {
            return JsonUtility.FromJson<DoorDataList>(jsonString);
        }
    }