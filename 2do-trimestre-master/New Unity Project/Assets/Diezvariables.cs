using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diezvariables : MonoBehaviour {

    public int maicol, arnold, stiv, checho, flover, chucho, manuel, andres, santiago, willy, años;


    void Start ()
    {
        imprimirbienprron();
    
        maicol = 17;
        arnold = 38;
        stiv = 21;
        chucho = 28;
        checho = 22;
        manuel = 18;
        andres = 19;
        flover = 23;
        santiago = 24;
        willy = 28;
        
	}
	
	public void imprimirbienprron()
    {
        años = maicol + arnold + stiv + checho + chucho + manuel + andres + flover + santiago + willy;

        print("El resultado es:" + años);
    }



}
