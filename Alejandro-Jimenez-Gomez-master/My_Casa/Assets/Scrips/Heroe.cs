using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//clase para definir heroe
public class Heroe : MonoBehaviour
{
    //se crea un struct para almacenar los atributos de la clase
    struct VariablesHeroe
    {
        public GameObject formaDeHeroe;
        public string nombreDeHeroe;
        public int zombiesasesinados;
        public int puntosDeVidaDeHeroe;
        public string edad;
        public string localidad;
        public float rangoAtaque;
    }
    
    

     void Start()
     {
        //se definen algunas variables del heroe
            VariablesH.rangoAtaque = 1;
            VariablesH.edad = posibleEdad[Random.Range(0, posibleEdad.Length - 1)];
            VariablesH.localidad = posibleLocalidad[Random.Range(0, posibleLocalidad.Length - 1)];
            VariablesH.nombreDeHeroe = posiblesNombresDeHeroes[Random.Range(0, posiblesNombresDeHeroes.Length - 1)];
            Debug.Log("Hola, soy el heroe " + VariablesH.nombreDeHeroe + " y soy de la localidad de " + VariablesH.localidad + " y  tengo " + VariablesH.edad + " tengo " + VariablesH.puntosDeVidaDeHeroe + " puntos de vida");
            VariablesH.
            puntosDeVidaDeHeroe = 10;
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
    VariablesHeroe VariablesH;
}
