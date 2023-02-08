using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketCheck : MonoBehaviour
{
    public void OnSelectEntering(SelectEnterEventArgs args)
    {
        var shooe = args.interactableObject.transform.GetComponent<XRGrabInteractable>();
        Debug.Log("Au revoir");
        shooe.interactionLayers = LayerMask.GetMask("Ungrabable") ;
        gameObject.GetComponent<XRSocketInteractor>().interactionLayers = LayerMask.GetMask("Ungrabable");
    }
}
