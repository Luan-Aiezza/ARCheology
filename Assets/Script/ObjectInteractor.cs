using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteractor : MonoBehaviour, IInteractable
{
    private bool isHeld = false;

    [SerializeField] private SOObjectInfo objectInfo;
    [SerializeField] private float infoDisplayHeight = 2f;

    public void OnInteract()
    {
        Debug.Log("Interagindo com o cubo!");

        if (HoldingManager.Instance.TryPickUp(gameObject))
        {
            isHeld = true;
            ShowObjectInfo();
        }
        else if (isHeld)
        {
            HoldingManager.Instance.Drop();
            isHeld = false;
            HideObjectInfo();
        }
    }

    public void StopInteract()
    {
        Debug.Log("Parando de interagir com o cubo!");
    }

    // Update is called once per frame
    void Update()
    {
        if (InputHandler.TryRayCastHit(out RaycastHit hitObject))
        {
            if (hitObject.transform == transform)
            {
                OnInteract();
            }
        }

    }

    private void ShowObjectInfo()
    {
        if (objectInfo == null) return;

        var infoController = FindObjectOfType<ObjectInfoController>();

        if (infoController != null)
        {
            infoController.SetObjectInfo(objectInfo);
            infoController.SetVisible(true);

            infoController.transform.SetParent(transform);
            infoController.transform.localPosition = new Vector3(0, infoDisplayHeight, 0);
        }
    }

    private void HideObjectInfo()
    {
        var infoController = FindObjectOfType<ObjectInfoController>();

        if (infoController != null)
        {
            infoController.SetVisible(false);
            infoController.transform.SetParent(null);
        }
    }
}

