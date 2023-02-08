using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketCheck : MonoBehaviour
{
    public bool itemcheck = false;
    public void OnSelectEntering(SelectEnterEventArgs args)
    {
        StopAllCoroutines();
        StartCoroutine(ShooeAttachCoroutine(args));
    }

    IEnumerator ShooeAttachCoroutine(SelectEnterEventArgs args)
    {
        yield return new WaitForSeconds(0.5f);// WaitForEndOfFrame();

        var item = args.interactableObject.transform.GetComponent<XRGrabInteractable>();

        item.enabled = false;
        Rigidbody rb = item.GetComponent<Rigidbody>();
        rb.isKinematic = true;
        rb.useGravity = false;
        transform.GetComponent<XRBaseInteractor>().enabled = false;
        item.transform.parent = transform;

        itemcheck = true;

    }
}
