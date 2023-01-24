using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DangerZone : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 5f;
    bool inDanger = false;
    PlayerHealth player = null;

    [SerializeField] Text countdownText;

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Entered Danger Zone");
        currentTime = startingTime;
        inDanger = true;
        player = collision.GetComponent<PlayerHealth>();
       // countdownText.enabled = true; -- need to add
    }

    void OnTriggerExit(Collider collision)
    {
        currentTime = 0f;
        inDanger = false;
       /// countdownText.enabled = false; -- need to add
    }

    void Update()
    {
      
        if(inDanger)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
            {
                currentTime = 0;
                player.Die();
                // Once game over scene is made, load it here
            }

            //countdownText.text = currentTime.ToString("0"); -- need to add
            Debug.Log(currentTime.ToString("0"));
        }

    }
}
