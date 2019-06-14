using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    public List<Transform> goal;
    public int actualTarget;
    Vector3 desplazamientoAWaypointActual;

    void Start()
    {
        //Vector3 distanciaDelPoint = goal[] - this.transform.position;
        
        actualTarget = 0;
        

    }
    private void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        desplazamientoAWaypointActual = agent.destination;
        desplazamientoAWaypointActual = goal[actualTarget].position - transform.position;

        if (desplazamientoAWaypointActual.magnitude > 1)
        {
            Vector3 direccionMovimiento = desplazamientoAWaypointActual.normalized;
            transform.LookAt(direccionMovimiento + transform.position);
            transform.position += desplazamientoAWaypointActual * 1f * Time.deltaTime;
        }
        else if (desplazamientoAWaypointActual.magnitude <= 1)
        {
            actualTarget++;
            if (actualTarget == 8)
            {
                actualTarget = 0;
            }

        }



    }
}


