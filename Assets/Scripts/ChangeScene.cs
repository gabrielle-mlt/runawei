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

        // if scene === "map"
        // reset map    
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}