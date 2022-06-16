using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;

public class EnemyML_AI :Agent
{
    Rigidbody body;
    public Vector3 SpawnPosition;
    private void Start()
    {
        GetComponent<Rigidbody>();   
    }
    public Transform PlayerTarget;

    public override void OnEpisodeBegin()
    {
        if (this.transform.localPosition.y < 0)
        {
            this.body.angularVelocity = Vector3.zero;
            this.body.velocity = Vector3.zero;
            this.transform.localPosition = SpawnPosition;
        }
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(PlayerTarget.localPosition);
        sensor.AddObservation(this.transform.localPosition);
        sensor.AddObservation(body.velocity.x);
        sensor.AddObservation(body.velocity.z);
        //sensor.AddObservation(life);
    }
    public float forcemultiplier = 30;
    public override void OnActionReceived(ActionBuffers actions)
    {
        Vector3 move = Vector3.zero;
        move.x = actions.ContinuousActions[0];
        move.z= actions.ContinuousActions[1];
        body.AddForce(move * forcemultiplier);
        float DistanceToTarget=Vector3.Distance(this.transform.position, PlayerTarget.localPosition);

        if(DistanceToTarget<1.42f)
        {
            SetReward(1.0f);
            EndEpisode();
        }
        //else if(life<=0)
        //{
        //    EndEpisode();
        //}
    }
}
