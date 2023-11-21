using System.IO;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerData : MonoBehaviour
{
    public static void Save(int points, string name)
    {
        CollectionData oldData = Upload();
        if (oldData.points < points)
        {
            CollectionData newData = new CollectionData();
            newData.points = points;
            newData.name = name;

            string json = JsonUtility.ToJson(newData);
            File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        }

    }

    [Serializable]
    public class CollectionData
    {
        public int points;
        public string name;
    }

    public static CollectionData Upload()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            CollectionData data = JsonUtility.FromJson<CollectionData>(json);

            return data;
        }
        else
        {
            CollectionData data = new CollectionData();
            data.name = "Not Best Player";
            data.points = 0;

            return data;
        }
    }
}