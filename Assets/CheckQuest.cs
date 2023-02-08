using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CheckQuest : MonoBehaviour
{
    SocketCheck HolderScript;
    public Image ChildImage;
    [SerializeField] GameObject ItemHolder;

    // Start is called before the first frame update
    void Start()
    {
        HolderScript = ItemHolder.GetComponent<SocketCheck>();
        ChildImage = GetComponentInChildren<Image>();
    }


    // Update is called once per frame
    void Update()
    {
        if(HolderScript.itemcheck==true)
        {
            ChildImage.sprite = Resources.Load<Sprite>("checkbox_ok");
        }
        else
        {
            ChildImage.sprite = Resources.Load<Sprite>("checkbox_ok");
        }
    }
}
