using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DangerZone : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 5f;

    [SerializeField] Text countdownText;

    void OnCollisionEnter(Collision collision)
    {
        currentTime = startingTime;
    }

    void OnCollisionExit(Collision collision)
    {
        currentTime = 0f;
    }

   // void Update()
   // {
    //    currentTime -= 1 * Time.deltaTime;
   //     countdownText.text = currentTime.ToString("0");
//
   //     if (currentTime <= 0)
   //     {
   //         currentTime = 0;
   //     }
   // }
}
