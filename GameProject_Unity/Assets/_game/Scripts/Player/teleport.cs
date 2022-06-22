using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Teleport : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] NavMeshAgent agent;
    [Range(0, 100)] public int damage;
    [Range(0, 100)] public int damage1;
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Finish");
    }
    private void Update()
    {
        FollowEnemy();
    }
    void FollowEnemy()
    {
        if (target != null)
        {
            agent.destination = target.transform.position;
        }
    }

}

