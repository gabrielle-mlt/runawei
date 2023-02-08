using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketCheck : XRBaseInteractable
{
    public string TargetTag = string.Empty;
    [SerializeField] GameObject Left_Shoe;
    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        base.OnSelectEntering(args);
        var interactor = args.interactorObject;

        if(args.interactorObject.Equals(Left_Shoe))
        {
            base.OnDisable();
         
        }
    }
}
