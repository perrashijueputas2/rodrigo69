using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    public List<Transform> goal;
    public int actualTarget = 0;
    Vector3 desplazamientoAWaypointActual;
    void Start()
    {
        //Vector3 distanciaDelPoint = goal[] - this.transform.position;
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        desplazamientoAWaypointActual = agent.destination;
        desplazamientoAWaypointActual = goal[actualTarget].position;

        

    }
    private void Update()
    {
        if (desplazamientoAWaypointActual.magnitude <= 1)
        {
            actualTarget++;
        }
        else
        {
            Vector3 direccionMovimiento = desplazamientoAWaypointActual.normalized;
            transform.LookAt(direccionMovimiento + transform.position);
            transform.position += desplazamientoAWaypointActual * 1 * Time.deltaTime;
        }
    }
}


