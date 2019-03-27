using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fredy : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 posicionAzar;
    public float velocidadMovimiento = 1.5f;
    public float velocidadPerseguir = 3f;
    public float velocidadRotacion = 30f;
    public float tiempoDeumbular = 5f;
    float referenciaDeambular = 2; 
    float referenciaEstatico = 3;
    public float tiempoEstatico = 2f;
    public float rangoVista = 10f;
    public float rangoAtaque = 2f;
    public float distancia;
    public float DistanciaParaHeroe ;
    public GameObject zombie, heroe;
    int counter = 0;
    public ParteCuerpo miParteCuerpo;



    void Start()
    {
        controller = GetComponent<CharacterController>();
        referenciaDeambular = tiempoDeumbular;
        referenciaEstatico = tiempoEstatico;
        heroe = GameObject.Find("heroe");
        zombie = GameObject.Find("zombie");
        
    }

    void Update()
    {
        distanciar();
        DañoParaElHeroe();
    }
    public void DañoParaElHeroe()
    {
        DistanciaParaHeroe = Vector3.Distance(this.transform.position, heroe.transform.position);

        if (DistanciaParaHeroe < rangoAtaque)
        {
            heroe.GetComponent<Heroe>().HacerDaño(miParteCuerpo.ToString());

        }
        
    }


    void distanciar()
    {
        distancia = Vector3.Distance(transform.position, heroe.transform.position);
        if (distancia < rangoVista)
        {
            Perseguir();
        }
        else
        {
           Deambular();
        }

    }
    void Deambular()
    {
        if (tiempoDeumbular > 0)
        {
            Quaternion rotacion = Quaternion.LookRotation(posicionAzar);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotacion, velocidadRotacion * Time.deltaTime);
            Vector3 movimiento = transform.TransformDirection(Vector3.forward);
            controller.SimpleMove(movimiento * velocidadMovimiento);
            tiempoDeumbular -= Time.deltaTime;
        }
        else if (tiempoDeumbular < 0 && tiempoEstatico > 0)
        {
            tiempoEstatico -= Time.deltaTime;
        }
        else
        {
            posicionAzar = new Vector3(Random.Range(-100f, 100f), 0, Random.Range(-100f, 100f));
            tiempoDeumbular = referenciaDeambular;
            tiempoEstatico = referenciaEstatico;
        }

        print("deambulando");

    }
    public void Perseguir()
    {
        Vector3 direccion = (heroe.transform.position - this.transform.position);
        direccion.y = 0;
        Quaternion rotacion = Quaternion.LookRotation(direccion);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotacion, velocidadRotacion * Time.deltaTime);
        Vector3 movimiento = transform.TransformDirection(Vector3.forward);
        controller.SimpleMove(movimiento * velocidadPerseguir);
        tiempoDeumbular -= Time.deltaTime;

        print("persiguiendo");

    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangoVista);
        
    }
}
