using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectar : MonoBehaviour
{
    public Transform heroePosición;
    Transform enemyTransform;
    int rangoDeVisión = 10;
    float timer;

    private void Start()
    {
        enemyTransform = this.transform;
    }
    private void Update()
    {
        Detecta();
    }

    bool Detecta()
    {
        Vector3 distanciaDelJugador = heroePosición.position - enemyTransform.position;
        float magnitud = distanciaDelJugador.magnitude;
        if (magnitud < rangoDeVisión)
        {
            float productoPunto = Vector3.Dot(enemyTransform.forward, distanciaDelJugador.normalized);
            if (productoPunto >= 0.5)
            {

                RaycastHit hit;
                if (Physics.Raycast(enemyTransform.position + distanciaDelJugador.normalized * 1.01f, distanciaDelJugador.normalized, out hit, Mathf.Infinity))
                {

                    Debug.DrawRay(enemyTransform.position + distanciaDelJugador.normalized * 1.01f, distanciaDelJugador.normalized * hit.distance, Color.magenta);
                    if (hit.collider.gameObject.name == "heroe")
                    {
                        Cronometro();
                        if (timer < 5 && timer > 3)
                        {
                            print("kiriku?");
                        }
                        if (timer <= 0)
                        {
                            print("kiriku, hpta");
                            timer = 5;


                        }

                        return true;

                    }
                }
            }
        }
        return false;
    }
    void Cronometro()
    {
        timer -= Time.deltaTime;
    }
}
