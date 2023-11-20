using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    TMP_InputField inputName;
    public static string namePlayer;

    void Start()
    {
        inputName = GameObject.Find("InputName").GetComponent<TMP_InputField>();
    }
    public void UploadScene()
    {
        SceneManager.LoadScene(1);
        if (inputName.text != "")
        {
            namePlayer = inputName.text;
        }
        else
        {
            namePlayer = "Player";
        }
    }
}
