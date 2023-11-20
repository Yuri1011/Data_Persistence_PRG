using System.IO;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerData : MonoBehaviour
{
    public static void Save(int points, string name)
    {
        CollectionData data = new CollectionData();
        data.points = points;
        data.name = name;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    [Serializable]
    public class CollectionData
    {
        public int points;
        public string name;
    }
}