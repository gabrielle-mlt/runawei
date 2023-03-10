using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    SocketCheck LockScript;
    SocketCheck LeftScript;
    SocketCheck RightScript;

    [SerializeField] GameObject LockHolder;
    [SerializeField] GameObject Left;
    [SerializeField] GameObject Right;
    [SerializeField] GameObject Tel;
    [SerializeField] GameObject WinMenu;
    [SerializeField] GameObject Timer;

    void Start()
    {
        LockScript = LockHolder.GetComponent<SocketCheck>();
        LeftScript = Left.GetComponent<SocketCheck>();
        RightScript = Right.GetComponent<SocketCheck>();

    }

    // Update is called once per frame
    void Update()
    {
        if(RightScript.itemcheck==true && LeftScript.itemcheck==true && LockScript.itemcheck==true)
        {
            gameObject.GetComponent<BoxCollider>().enabled = true;
            WinMenu.SetActive(true);
            Timer.SetActive(false);
        }
    }
}
