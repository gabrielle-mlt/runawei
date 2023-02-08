using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketCheck : MonoBehaviour
{
    public string TargetTag = string.Empty;
    [SerializeField] GameObject Left_Shoe;
    public void OnSelectEntering(SelectEnterEventArgs args)
    {
        var interactor = args.interactorObject;
        Debug.Log("Au revoir");

    }
}
