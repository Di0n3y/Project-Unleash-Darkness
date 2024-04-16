using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    private float timer;
    public float changeDestinationTime = 2f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = changeDestinationTime;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SetRandomDestination();
            timer = changeDestinationTime;
        }
    }

    void SetRandomDestination()
    {
        Vector3 randomPoint = Random.insideUnitSphere * 10f + transform.position;
        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomPoint, out hit, 10f, NavMesh.AllAreas))
        {
            agent.SetDestination(hit.position);
        }
    }
}
