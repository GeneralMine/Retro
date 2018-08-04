using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    public Transform Player;
    NavMeshAgent agent;
    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = Player.position;
        if (agent.isStopped) Debug.Log("stopped");
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;
        agent.isStopped = true;
    }*/
}
