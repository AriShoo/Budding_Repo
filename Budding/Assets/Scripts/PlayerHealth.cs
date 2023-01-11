using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static event Action OnPlayerDeath;
    public float HitPoints;
    public float MaxHitPoints = 100;
    public HealthBarBehave HealthBar;
    
// ------------------------------------------------------------------- //

    void Start()
    {
        HitPoints = MaxHitPoints;
        HealthBar.SetHealth(HitPoints,  MaxHitPoints);
    }

// ------------------------------------------------------------------- //

    public void  TakeDamage(float damage)
    {
        HitPoints -= damage;   

        if (HitPoints <= 0)
        {
            HitPoints = 0;
            //Display game over screen
            OnPlayerDeath?.Invoke();
        }
    }
}
