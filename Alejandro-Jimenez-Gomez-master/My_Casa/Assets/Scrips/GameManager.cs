using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//clase principal
public class GameManager : MonoBehaviour
{
    //se crea un struct para almacenar los atributos de la clase
    struct VariablesGameManager
    {
        public CharacterController controller;
        public GameObject heroeContenido;
        public float rango;
        public int numeroParaEscogerAldeanoOZombie;
        public int numeroDeInstancias;
        public Transform jugador;
        public string edad;
    }
    
    void Start()
    {
        //se definen variables, se da objeto primitivo, se agregan componentes y se modifican para el heroe
        Variables.rango = 10;
        Variables.heroeContenido = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        Variables.heroeContenido.AddComponent<Camera>();
        Variables.heroeContenido.name = "heroe";
        Vector3 posiciondelHeroe = new Vector3();
        posiciondelHeroe.x = Random.Range(80, 10);
        posiciondelHeroe.y = Random.Range(30, 50);
        posiciondelHeroe.z = Random.Range(80, 10);
        Variables.heroeContenido.transform.position = posiciondelHeroe;
        Variables.heroeContenido.AddComponent<Rigidbody>();
        Variables.heroeContenido.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        Variables.heroeContenido.AddComponent<Heroe>();
        Variables.heroeContenido.AddComponent<Movimiento_Heroe>();
        Variables.heroeContenido.AddComponent<Camara_Heroe>();
        //se crea un numero aleatorio para definir cuantas instancias de zombies y aldeanos se van a crear
        Variables.numeroDeInstancias = Random.Range(10, 19);
        //se crea un bucle para crear los zombies y los aldeanos, ademas, se define un entero aleatorio para que decida cuando se crea un zombie y cuando un aldeano
        for (int i = 0; i < Variables.numeroDeInstancias; i++)
        {
            Variables.numeroParaEscogerAldeanoOZombie = Random.Range(0, 2);
            if (Variables.numeroParaEscogerAldeanoOZombie == 0)
            {
                new Zombie();
            }
            else
            {
                new Aldeano();
            }
        }
    }
    void Update()
    {
     
    }
    VariablesGameManager Variables;
}
//se crea un enum para definir los gustos del zombie
public enum ParteCuerpo
{
    Nalguitas,
    Musculos_cremastericos,
    Tripitas,
    Tetillas_peludas,
    Esos_dos_pares_de_labios_tuyos_bb,
}
