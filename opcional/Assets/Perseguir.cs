using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perseguir : MonoBehaviour
{
    public Transform heroePosición;
    Transform enemyTransform;
    int rangoDeVisión = 10;
    float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        enemyTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Reconocer();
        
    }
    bool Reconocer()
    {
        Vector3 distanciaDelJugador = heroePosición.position - enemyTransform.position;
        float magnitud = distanciaDelJugador.magnitude;
        if (magnitud<rangoDeVisión)
        {
            float productoPunto = Vector3.Dot(enemyTransform.forward, distanciaDelJugador.normalized);
            if (productoPunto >= 0.5)
            {
                RaycastHit hit;
                if (Physics.Raycast(enemyTransform.position + distanciaDelJugador.normalized * 1.01f, distanciaDelJugador.normalized,out hit, Mathf.Infinity))
                {
                    Debug.DrawRay(enemyTransform.position + distanciaDelJugador.normalized * 1.01f, distanciaDelJugador.normalized * hit.distance, Color.magenta);
                    if (hit.collider.gameObject.name == "heroe")
                    {
                        
                        print("kiriku");
                        return true;
                        
                    }
                }
            }
        }
        return false;
    }
    
}
