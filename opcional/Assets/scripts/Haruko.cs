using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haruko : MonoBehaviour
{
    //float velocidad;
    //float velocidadNormal;
    //Rigidbody playerRGB;
    //Transform playerTransform;
    //void Start()
    //{
    //    playerRGB = GetComponent<Rigidbody>();
    //    playerTransform = transform;
    //    velocidad = Random.Range(0.1f, 0.5f);
    //    velocidadNormal = velocidad;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        this.transform.position += this.transform.forward * velocidad;
    //        if (Input.GetKey(KeyCode.LeftShift))
    //        {
    //            velocidad = 0.5f;
    //        }
    //        else
    //        {
    //            velocidad = velocidadNormal;
    //        }
    //    }
    //    if (Input.GetKey(KeyCode.S))
    //    {
    //        transform.position -= transform.forward * velocidad;
    //    }
    //    else
    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        this.transform.position -= this.transform.right * velocidad;
    //    }
    //    else
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        this.transform.position += this.transform.right * velocidad;
    //    }

    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<IInteractuable>() != null)
        {
            other.GetComponentInParent<IInteractuable>().Interact();
        }
    }

}
