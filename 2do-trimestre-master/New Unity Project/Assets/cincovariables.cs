using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Esta es el nomrbe de la clase y su nivel de acceso
public class cincovariables : MonoBehaviour
{
    public int maicol, freddy, flover, chucho, checho;
    public float promedio;

    //Aquí se marca que va a pasar cuando se inicie el juego
    public void Start()
    {
        maicol = 17;
        freddy = 38;
        flover = 21;
        chucho = 28;
        checho = 22;
        promedio = (maicol + freddy + flover + chucho + checho) / 5;

        print("El promedio es:" + promedio);

    }

    
}
