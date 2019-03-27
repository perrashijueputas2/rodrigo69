using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Promediodedocevariables : MonoBehaviour
{
    public double maicol, arnold, stiv, checho, flover, chucho, manuel, andres, santiago, willy,x,y, promedio;

    void Start()
    {
        imprimir();

        maicol = 17.5;
        arnold = 38.6;
        stiv = 21.6;
        chucho = 28.4;
        checho = 22.4;
        manuel = 18.2;
        andres = 19.6;
        flover = 23.8;
        santiago = 24.3;
        willy = 28.1;
        x = 22.65;
        y = 26.28;
         
    }
    public void imprimir()
    {
        promedio = (maicol + arnold + stiv + checho + chucho + manuel + andres + flover + santiago + willy + x + y) / 12;


        print("El promedio de años es:" + promedio);
    }

}
