using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    public float countdown = 5;
    public bool countdownStart;

    void OnCollisionEnter(Collision collision)
    {
        countdownStart = true;
    }

    void OnCollisionExit(Collision collision)
    {
        countdown = 0;
        countdownStart = false;
    }

    void update()
    {
        if (countdown > 0)
        {
            countdown -= Time.deltaTime;
        }

        else
        {
            Debug.Log("You're out of time!");
            countdown = 0;
            countdownStart = false;

        }
    }
}
