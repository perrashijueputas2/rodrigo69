using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perseguir : MonoBehaviour
{
    public Transform heroePosición;
    Transform enemyTransform;
    int rangoDeVisión = 10;
    float tiempo;
    float timer;
    public float vueltas;
    public float condicionVueltas;
    public GameObject heroe;
    public Vector3 posicionAzar;
    public float velocidadRotacion =1000f;
    // Start is called before the first frame update
    void Start()
    {
        enemyTransform = this.transform;
        timer = 5;
        vueltas = 3;
        condicionVueltas = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Reconocer();
    }
    bool Reconocer()
    {
        
        vueltas -= Time.deltaTime;
        if (vueltas < 1 )
        {
            condicionVueltas -= Time.deltaTime;
            //posicionAzar.x = Random.Range(100, -100);
            //posicionAzar.y = 0;
            //posicionAzar.z = Random.Range(100, -100);
            //Quaternion rotacion = Quaternion.LookRotation(posicionAzar);
            //transform.rotation = Quaternion.Slerp(this.transform.rotation, rotacion, velocidadRotacion);
            transform.Rotate(new Vector3(0, 15, 0) * Time.deltaTime);
            print("hice vueltas?");
            
            if (condicionVueltas <1 )
            {
                vueltas = 3;
                condicionVueltas = 5;
            }
            
            
        }
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
                        vueltas = 100;
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
            vueltas = 3;
        }
        return false;
        
    }
    void Cronometro()
    {
        timer -= Time.deltaTime;
    }
    bool Girar()
    {
       
        return false;
    }
    
}
