using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public void LoadMap()
    {
        SceneManager.LoadScene("Map");
        Debug.Log("test");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("StartingScene");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}