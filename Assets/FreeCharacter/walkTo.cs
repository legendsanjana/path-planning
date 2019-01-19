using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class walkTo : MonoBehaviour {
    public Transform goal;
	// Use this for initialization
	void Start () {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
	}
	

}
