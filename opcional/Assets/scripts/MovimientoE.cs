using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MovimientoE : MonoBehaviour
{
    public List<GameObject> Waypoints = new List<GameObject>();

    public Transform Point;

    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = Point.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
