using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroe : MonoBehaviour {

    public GameObject formaDeHeroe;
    public string nombreDeHeroe;
    public int zombiesasesinados;
    public int puntosDeVidaDeHeroe;
    public string edad;
    public string localidad;
    public float rangoAtaque = 1;
    

    private void Start()
    {
        edad = posibleEdad[Random.Range(0, posibleEdad.Length - 1)];
        localidad = posibleLocalidad[Random.Range(0, posibleLocalidad.Length - 1)];
        nombreDeHeroe = posiblesNombresDeHeroes[Random.Range(0, posiblesNombresDeHeroes.Length - 1)];
        Debug.Log("Hola, soy el heroe " + nombreDeHeroe + " y soy de la localidad de " + localidad + " y  tengo " + edad + " tengo " + puntosDeVidaDeHeroe + " puntos de vida");
        puntosDeVidaDeHeroe = 10;
    }
    private void Update()
    {

    }
   
    public void HacerDaño(string parteDelCuerpo)
    {
            Debug.Log("estoy detectando");
            print("Ya valiste verga prro, te wua comer tus " + parteDelCuerpo + " yumi");
    }


    public string[] posibleEdad = new string[]
    {
            "15 añitos, todavia virgen",
            "16 años, me mato a pajas",
            "17 años, todo vicioso",
            "18 años, soy remiso",
    };
        
        string[] posibleLocalidad = new string[]
        {
            "teusaquillo",
            "jardin cucho",
            "la comuna nororiental",
            "bosa",
            "la casa de Mora",
        };
        
        string[] posiblesNombresDeHeroes = new string[]
        {
            "Salchipapaman",
            "Pipo",
            "Jose Carlos",

        };

        
        

        
        
        
        

 
}
