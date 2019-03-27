using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamiento_Zombie : MonoBehaviour
{
    public struct InformacionComportamientoZombie
    {
        public CharacterController controller;
        public Vector3 posicionAzar;
        public float velocidadMovimiento;
        public float velocidadPerseguir;
        public float velocidadRotacion;
        public float referenciaDeambular;
        public float referenciaEstatico;
        public float rangoVista;
        public float rangoAtaque;
        public float distancia;
        public float DistanciaParaHeroe;
        public GameObject zombie, heroe;
        public ParteCuerpo miParteCuerpo;
        public Comportamiento ComportamientoActual;
        public float Timer;
        public float gravedad;
    }
    
    void Start()
    {

        VariablesZombie.velocidadMovimiento = 1.5f;
        VariablesZombie.velocidadPerseguir = 3f;
        VariablesZombie.velocidadRotacion = 1f;
        VariablesZombie.referenciaDeambular = 2;
        VariablesZombie.referenciaEstatico = 3;
        VariablesZombie.rangoVista = 10f;
        VariablesZombie.rangoAtaque = 2f;
        VariablesZombie.Timer = 5f;
        VariablesZombie.gravedad = -9.8f;
        VariablesZombie.controller = GetComponent<CharacterController>();
        VariablesZombie.heroe = GameObject.Find("heroe");
        VariablesZombie.zombie = GameObject.Find("zombie");
    }

    void Update()
    {
        DañoParaElHeroe();

        if(!Physics.Raycast(this.transform.position, Vector3.down, 0.6f, 1 << LayerMask.NameToLayer("Tierra")))
        {
            this.transform.position += Vector3.up * VariablesZombie.gravedad * Time.deltaTime;
        }

        VariablesZombie.Timer -= Time.deltaTime;
  
        if (VariablesZombie.Timer < 0f)
        {
            VariablesZombie.ComportamientoActual = (Comportamiento)Random.Range(0, System.Enum.GetValues(typeof(Comportamiento)).Length);
            VariablesZombie.Timer = 5;
        }

        if(VariablesZombie.ComportamientoActual == Comportamiento.Moving)
        {
            Deambular();    
        }

        distanciar();
    }
    public void DañoParaElHeroe()
    {
        VariablesZombie.DistanciaParaHeroe = Vector3.Distance(this.transform.position, VariablesZombie.heroe.transform.position);

        if (VariablesZombie.DistanciaParaHeroe < VariablesZombie.rangoAtaque)
        {
            VariablesZombie.heroe.GetComponent<Heroe>().HacerDaño(VariablesZombie.miParteCuerpo.ToString());

        }

        
    }


    void distanciar()
    {
        VariablesZombie.distancia = Vector3.Distance(this.transform.position, VariablesZombie.heroe.transform.position);
        if (VariablesZombie.distancia < VariablesZombie.rangoVista)
        {
            Perseguir();
        }

    }
    void Deambular()
    {
        VariablesZombie.posicionAzar.x = Random.Range(100, -100);
        VariablesZombie.posicionAzar.y = 0;
        VariablesZombie.posicionAzar.z = Random.Range(100, -100);
        Quaternion rotacion = Quaternion.LookRotation(VariablesZombie.posicionAzar);
        transform.rotation = Quaternion.Slerp(this.transform.rotation, rotacion, VariablesZombie.velocidadRotacion * Time.deltaTime);
        Vector3 movimiento = transform.TransformDirection(Vector3.forward);
        VariablesZombie.controller.SimpleMove(movimiento * VariablesZombie.velocidadMovimiento);
    }
    public void Perseguir()
    {
        Vector3 direccion = (VariablesZombie.heroe.transform.position - this.transform.position);
        direccion.y = 0;
        Quaternion rotacion = Quaternion.LookRotation(direccion);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotacion, VariablesZombie.velocidadRotacion * Time.deltaTime);
        Vector3 movimiento = transform.TransformDirection(Vector3.forward);
        VariablesZombie.controller.SimpleMove(movimiento * VariablesZombie.velocidadPerseguir);
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, VariablesZombie.rangoVista);
    }
    public InformacionComportamientoZombie VariablesZombie;
    
}

public enum Comportamiento
{
    Idle,
    Moving,
};
