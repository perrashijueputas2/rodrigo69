using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aldeano
{
    //se crea un struct para almacenar los atributos de la clase
    struct VariablesAldeano
    {
        public GameObject aldeanoMesh;
        public string nombreDeAldeano;
        public int edad;
        public string localidad;
        public int puntosDeVidaDeAldeanos;
    }
    
    //se crea un constructor donde se van a almacenar los datos del aldeano y se va a escoger cada dato aleatoriamente cada vez que se instancie
    public Aldeano()
    {
        //se crea un array de strings para los posibles nombres
        string[] posiblesNombresDeAldeanos = new string[]
        {
            "Roberto",
            "Augusto",
            "Jeronimo",
            "Antonio",
            "Federico",
            "Ramón",
            "Alfonso",
            "Julio",
            "John Mario",
            "Mora",
            "el papá de Mora",
            "la hermanita de Mora",
            "Mario John",
            "John Malio",
            "Malio John",
            "Malio el vicioso",
            "Malio rehabilitado",
            "Malio recaido",
            "Checho el vicioso sin demanda",
            "Checho el vicioso con demanda",
            "Checho en la calle porque lo volvieron a echar",
            "Checho con otro hijo",

        };
        //se obtiene un nombre aleatorio
        InformacionAldeano.nombreDeAldeano = posiblesNombresDeAldeanos[Random.Range(0, posiblesNombresDeAldeanos.Length - 1)];
        //se asigna una edad aleatoria
        InformacionAldeano.edad = Random.Range(15, 101);
        //se asignan puntos de vida
        InformacionAldeano.puntosDeVidaDeAldeanos = 5;
        //se le da un objeto primitivo para el cuerpo
        InformacionAldeano.aldeanoMesh = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //se le da un vector 3 aleatorio para su aparicion
        Vector3 posicionDeAldeano = new Vector3();
        posicionDeAldeano.x = Random.Range(20, 10);
        posicionDeAldeano.y = Random.Range(15, 25);
        posicionDeAldeano.z = Random.Range(20, 10);
        InformacionAldeano.aldeanoMesh.transform.position = posicionDeAldeano;
        //se imprime un mensaje con su informacion
        Debug.Log("Hola, soy " + InformacionAldeano.nombreDeAldeano + " y tengo " + InformacionAldeano.edad + " años");
    }
    VariablesAldeano InformacionAldeano;
}
