using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckQuest : MonoBehaviour
{
    SocketCheck HolderScript;
    [SerializeField] GameObject ItemHolder;
    public Sprite newSprite;

    // Start is called before the first frame update
    void Start()
    {
        HolderScript = ItemHolder.GetComponent<SocketCheck>();
    }


    // Update is called once per frame
    void Update()
    {
        if (HolderScript.itemcheck == true)
        {
            gameObject.GetComponent<Image>().sprite = newSprite;
        }
    
    }
}
