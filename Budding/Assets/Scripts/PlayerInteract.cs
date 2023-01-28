using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);

            foreach (Collider collider in colliderArray) {
                if (collider.TryGetComponent(out NPCInteractable nPCInteractable)) {
                    nPCInteractable.Interact();
                }
                
            }
        }
    }

    public NPCInteractable GetInteractableObject()
    {
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray) {
            if (collider.TryGetComponent(out NPCInteractable nPCInteractable)) {
                return nPCInteractable;
            }    
        }
         return null;
    }
    

}
