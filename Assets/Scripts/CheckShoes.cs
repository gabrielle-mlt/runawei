using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckShoes : MonoBehaviour
{
    SocketCheck Left;
    SocketCheck Right;

    [SerializeField] GameObject ItemHolderLeft;
    [SerializeField] GameObject ItemHolderRight;

    public Sprite newSprite;

    // Start is called before the first frame update
    void Start()
    {
        Left = ItemHolderLeft.GetComponent<SocketCheck>();
        Right = ItemHolderRight.GetComponent<SocketCheck>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Left.itemcheck == true && Right.itemcheck==true)
        {
            gameObject.GetComponent<Image>().sprite = newSprite;
        }
    
    }
}
