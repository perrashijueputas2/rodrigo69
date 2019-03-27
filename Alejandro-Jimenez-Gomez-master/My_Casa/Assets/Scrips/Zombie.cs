using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie
{
    public struct InformacionZombie
    {
        public GameObject zombieMesh;
        public string nombredezombie;
        public string parteDelCuerpo;
        public ParteCuerpo EscogedorDeParteCuerpo;
    }
    public Zombie()
    {

        string[] listadenombresdeZombie = new string[]
        {
            "Humberto el zombie del amor",
            "Alberto el zombie heterocomegente",
            "Checho el zombie preñador",
            "Un testigo de jehova, tienes unos minutos para hablar sobre nuestro salvador?",
            "Flover, miau",
        };

        VariablesZombie.nombredezombie = listadenombresdeZombie[Random.Range(0, listadenombresdeZombie.Length - 1)];
        VariablesZombie.zombieMesh = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Vector3 posicionZombie = new Vector3();
        posicionZombie.x = Random.Range(50, -50);
        posicionZombie.y = Random.Range(20, 50);
        posicionZombie.z = Random.Range(80, -50);
        VariablesZombie.zombieMesh.transform.position = posicionZombie;
       
        int coloreszombies = Random.Range(0, 3);
        VariablesZombie.zombieMesh.AddComponent<CharacterController>();
        VariablesZombie.zombieMesh.AddComponent<Comportamiento_Zombie>();

        VariablesZombie.zombieMesh.name = "zombie";
        VariablesZombie.EscogedorDeParteCuerpo = (ParteCuerpo)Random.Range(0, 5);
        VariablesZombie.zombieMesh.GetComponent<Comportamiento_Zombie>().VariablesZombie.miParteCuerpo = VariablesZombie.EscogedorDeParteCuerpo;



        if (coloreszombies == 0)
        {
            VariablesZombie.zombieMesh.GetComponent<Renderer>().material.color = Color.cyan;
            Debug.Log("Hola soy " + VariablesZombie.nombredezombie + " y soy de color Cyan, waaarrrr, quiero comer");
        }
        if (coloreszombies == 1)
        {
            VariablesZombie.zombieMesh.GetComponent<Renderer>().material.color = Color.green;
            Debug.Log("Hola soy " + VariablesZombie.nombredezombie + " y soy de color Green, waaarrrr, quiero comer");
        }
        if (coloreszombies == 2)
        {
            VariablesZombie.zombieMesh.GetComponent<Renderer>().material.color = Color.magenta;
            Debug.Log("Hola soy " + VariablesZombie.nombredezombie + " y soy de color Magenta, waaarrrr, quiero comer");
        }
    }
    InformacionZombie VariablesZombie;

}

