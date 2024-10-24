using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObserver : MonoBehaviour
{
    public delegate void InteractionEvent(IInteractable interactable);
    public static event InteractionEvent OnInteractionTriggered;

    private IInteractable currentInteractable;

    private void Update()
    {
        if (currentInteractable != null)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                currentInteractable.Mirar();
                OnInteractionTriggered?.Invoke(currentInteractable);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                currentInteractable.Usar();
                OnInteractionTriggered?.Invoke(currentInteractable);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        IInteractable interactable = other.GetComponent<IInteractable>();
        if (interactable != null)
        {
            currentInteractable = interactable;
            UIManager.Instance.ShowInteractionButtons();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<IInteractable>() != null)
        {
            currentInteractable = null;
            UIManager.Instance.HideInteractionButtons();
        }
    }
}
