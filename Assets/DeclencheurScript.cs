using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclencheurScript : MonoBehaviour
{
    TimerScript timerScript;

    [SerializeField] GameObject Timer;
    [SerializeField] GameObject oGameOverMenu;

    // Start is called before the first frame update
    void Start()
    {
        timerScript = Timer.GetComponent<TimerScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (timerScript.fTimer<=0 )
        {
            oGameOverMenu.SetActive(true);
        }
    }
}
