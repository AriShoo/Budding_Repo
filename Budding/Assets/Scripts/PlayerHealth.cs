using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public static event Action OnPlayerDeath;
    public float HitPoints;
    public float MaxHitPoints = 100;
    public HealthBarBehave HealthBar;
    public float invincibiltyDur = 1f;
    private float lastHitTime = 0f;
    
// ------------------------------------------------------------------- //

    void Start()
    {
        HitPoints = MaxHitPoints;
        HealthBar.SetHealth(HitPoints, MaxHitPoints);
    }

// ------------------------------------------------------------------- //

    public void TakeDamage(float damage)
    {
        if(Time.time < lastHitTime + invincibiltyDur)
        {
            return;
        }

        HitPoints -= damage;
        lastHitTime = Time.time;

        if (HitPoints <= 0)
        {
            HitPoints = 0;
            Die();
        }

        HealthBar.SetHealth(HitPoints, MaxHitPoints);
    }

    public void Die()
    {
        //Display game over screen
        HitPoints = 0;
        OnPlayerDeath?.Invoke();
        
    }

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        EnemyAI enemyAI = hit.collider.GetComponent<EnemyAI>();
        if (enemyAI != null)
        {
            TakeDamage(enemyAI.damage);

        }
    }
}
