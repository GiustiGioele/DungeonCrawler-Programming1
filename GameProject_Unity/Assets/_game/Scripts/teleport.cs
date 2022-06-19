using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class teleport : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] GameObject arrive;
    [SerializeField] GameObject startTeleport;
    [SerializeField] Collider collider;
    void Agent()
    {
        agent.Move(arrive.transform.position);
    }
    private void Update()
    {
        if(agent.transform.position.x==startTeleport.transform.position.x)
        {
            Agent();
        }
    }

}

