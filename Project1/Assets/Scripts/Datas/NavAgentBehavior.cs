using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]

public class NavAgentBehavior : MonoBehaviour
{

    private NavMeshAgent agent;
    public Transform player;
    public float speed = 8f;
    private Transform currentDestination;
    
    public List<Transform>


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        currentDestination = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        currentDestination = player;
    }

    private void OnTriggerExit(Collider other)
    {
        currentDestination = transform;
    }

    void Update()
    {
        agent.destination = player.position;
    }
}
