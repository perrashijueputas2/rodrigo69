using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girar : MonoBehaviour
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
    void Reconocer()
    {
     
        vueltas -= Time.deltaTime;
        if (vueltas < 1 )
        {
            condicionVueltas -= Time.deltaTime;
            transform.Rotate(new Vector3(0, 15, 0) * Time.deltaTime);
            if (condicionVueltas <1 )
            {
                vueltas = 3;
                condicionVueltas = 5;
            }
        } 
    }
    //bool Girar()
    //{
       
    //    return false;
    //}
    
}
