using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//clase para el movimiento y creacion de la camara para el heroe
public class Camara_Heroe : MonoBehaviour
{
    //se crea un struct para almacenar los atributos de la clase
    struct CamaraPalHeroe
    {
        public float mouseX;
        public float mouseY;
        public bool InvertedMouse;
    }
	void Update ()
    {
        //se llama una funcion desde el update para que cada frame se actualice
        Camararotacion();
    }
    public void Camararotacion()
    {
        //se definen parametros y condiciones para poder usar la camara, tanto invertida como normal
        structCamarita.mouseX += Input.GetAxis("Mouse X");
        if (structCamarita.InvertedMouse)
        {
            structCamarita.mouseY += Input.GetAxis("Mouse Y");
        }
        else
        {
            structCamarita.mouseY -= Input.GetAxis("Mouse Y");
        }
        transform.eulerAngles = new Vector3();
        GetComponent<Camera>().transform.eulerAngles = new Vector3(structCamarita.mouseY, structCamarita.mouseX, 0);
        
    }
    CamaraPalHeroe structCamarita;
}
