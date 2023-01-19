using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    GameObject Player;
    public int damage;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        UpdateDestination();
    }
    
    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1 )
        {
            IterateWaypointIndex();
            UpdateDestination();
        }
    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
        if(waypointIndex== waypoints.Length)
        {
            waypointIndex = 0;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player.GetComponent<PlayerHealth>().TakeDamage(damage);

        }
    }
}
