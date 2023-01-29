using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunDrop : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.SunCollected();
            gameObject.SetActive(false);
        }
    }
}
