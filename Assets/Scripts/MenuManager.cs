using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static TMP_InputField InputName;
    private static string _namePlayer;
    public static MenuManager instance;
    void Start()
    {
        InputName = GameObject.Find("InputName").GetComponent<TMP_InputField>();
    }
    public void UploadScene()
    {
        SceneManager.LoadScene(1);
        AssignName();
    }

    public static string AssignName()
    {
        if (InputName.text != "")
        {
            _namePlayer = InputName.text;
        }
        else
        {
            _namePlayer = "Player";
        }

        return _namePlayer;
    }
}