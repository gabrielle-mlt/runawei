using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public void changeScene(string sName)
    {
        SceneManager.LoadScene(sName);
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}