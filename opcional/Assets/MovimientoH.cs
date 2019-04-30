using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoH : MonoBehaviour
{
    float velocidad;
    float velocidadNormal;
   
    void Start()
    {
        velocidad = Random.Range(0.1f, 0.5f);
        velocidadNormal = velocidad;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += this.transform.forward * velocidad;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                velocidad = 0.5f;
            }
            else
            {
                velocidad = velocidadNormal;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * velocidad;
        }
        else
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position -= this.transform.right * velocidad;
        }
        else
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += this.transform.right * velocidad;
        }

    }
    
}
