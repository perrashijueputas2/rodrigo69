using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Esta es el nomrbe de la clase y su nivel de acceso
public class holamundo : MonoBehaviour {

    //Aquí se marca que va a pasar cuando se inicie el juego
    void Start ()
    {    //En esta linea se le dice al sistema que "active" la funcion llamarholamundo
        llamarholamundo();
	}
	//aqui creamos una funcion llamada llamarholamundo
    public void llamarholamundo()
    {
        //aqui definimos lo que hara llamarholamundo
        Debug.Log("holamundo");
    }

	
}
