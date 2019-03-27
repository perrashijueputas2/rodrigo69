using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CharacterController controller;
    GameObject heroeContenido;
    public float velocidad = 1f;
    public float mouseX;
    private float mouseY;
    public float rango = 10;
    
    public int numeroParaEscogerAldeanoOZombie;
    public int numeroDeInstancias;
    public bool InvertedMouse;
    public Transform jugador;
    string edad;

    void Start()
    {
        //instanciacion de heroe

        heroeContenido = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        heroeContenido.AddComponent<Camera>();
        heroeContenido.name = "heroe";
        heroeContenido.AddComponent<Rigidbody>();
        heroeContenido.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        heroeContenido.AddComponent<Heroe>();
        Vector3 posiciondelHeroe = new Vector3();
        posiciondelHeroe.x = Random.Range(80, 10);
        posiciondelHeroe.y = Random.Range(30, 50);
        posiciondelHeroe.z = Random.Range(80, 10);
        transform.position = posiciondelHeroe;
        heroeContenido.transform.position = posiciondelHeroe;

        //fin de instancia de heroe

        numeroDeInstancias = Random.Range(10, 19);
        for (int i = 0; i < numeroDeInstancias; i++)
        {
            numeroParaEscogerAldeanoOZombie = Random.Range(0, 2);
            if (numeroParaEscogerAldeanoOZombie == 0)
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
        Camararotacion();
        MovimientoHeroe();
        
    }
    
    public void Camararotacion()
    {
        
        mouseX += Input.GetAxis("Mouse X");
        if (InvertedMouse)
        {
            mouseY += Input.GetAxis("Mouse Y");
        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y");


        }
        heroeContenido.GetComponent<Camera>().transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
            transform.eulerAngles = new Vector3();
    }
    public void MovimientoHeroe()
    {
        if (Input.GetKey(KeyCode.W))
        {
            heroeContenido.transform.position += heroeContenido.transform.forward * velocidad;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                velocidad = 3f;
            }
            else
            {
                velocidad = 0.1f;
            }
        }
        else
        if (Input.GetKey(KeyCode.S))
        {
            heroeContenido.transform.position -= heroeContenido.transform.forward * velocidad;
        }
        else
        if (Input.GetKey(KeyCode.A))
        {
            heroeContenido.transform.position -= heroeContenido.transform.right * velocidad;
        }
        else
        if (Input.GetKey(KeyCode.D))
        {
            heroeContenido.transform.position += heroeContenido.transform.right * velocidad;
        }
        else
        {
            
        } 
        
    }
    
}

public class Zombie
{
    GameObject zombieMesh;
    string nombredezombie;
    string parteDelCuerpo;
    public float gravedad = -9.8f;
    public ParteCuerpo EscogedorDeParteCuerpo;
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
        
        nombredezombie = listadenombresdeZombie[Random.Range(0,listadenombresdeZombie.Length-1)];
        zombieMesh = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Vector3 posicionZombie = new Vector3();
        posicionZombie.x = Random.Range(50, -50);
        posicionZombie.y = Random.Range(20, 50);
        posicionZombie.z = Random.Range(80, -50);
        zombieMesh.transform.position = posicionZombie;
        posicionZombie.y += gravedad;
        int coloreszombies = Random.Range(0, 3);
        zombieMesh.AddComponent<CharacterController>();
        zombieMesh.AddComponent<Fredy>();

        zombieMesh.name = "zombie";
        EscogedorDeParteCuerpo = (ParteCuerpo)Random.Range(0, 5);
        zombieMesh.GetComponent<Fredy>().miParteCuerpo = EscogedorDeParteCuerpo;



        if (coloreszombies == 0 )
        {
            zombieMesh.GetComponent<Renderer>().material.color = Color.cyan;
            Debug.Log("Hola soy " + nombredezombie + " y soy de color Cyan, waaarrrr, quiero comer" );
        }
        if(coloreszombies == 1)
        {
            zombieMesh.GetComponent<Renderer>().material.color = Color.green;
            Debug.Log("Hola soy " + nombredezombie + " y soy de color Green, waaarrrr, quiero comer" );
        }
        if( coloreszombies == 2 )
        {
            zombieMesh.GetComponent<Renderer>().material.color = Color.magenta;
        Debug.Log("Hola soy " + nombredezombie + " y soy de color Magenta, waaarrrr, quiero comer");
        }
    }

    
}
public enum ParteCuerpo
{
    Nalguitas,
    Musculos_cremastericos,
    Tripitas,
    Tetillas_peludas,
    Esos_dos_pares_de_labios_tuyos_bb,
}

public class Aldeano
{
    GameObject aldeanoMesh;
    public string nombreDeAldeano;
    public int edad;
    public string localidad;
    public int puntosDeVidaDeAldeanos;

    public Aldeano()
    {
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
        nombreDeAldeano = posiblesNombresDeAldeanos[Random.Range(0, posiblesNombresDeAldeanos.Length - 1)];
        edad = Random.Range(15, 101);
        puntosDeVidaDeAldeanos = 5;
        aldeanoMesh = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Vector3 posicionDeAldeano = new Vector3();
        posicionDeAldeano.x = Random.Range(20, 10);
        posicionDeAldeano.y = Random.Range(4, 10);
        posicionDeAldeano.z = Random.Range(20, 10);
        aldeanoMesh.transform.position = posicionDeAldeano;
        Debug.Log("Hola, soy " + nombreDeAldeano + " y tengo " + edad + " años");
    }
}