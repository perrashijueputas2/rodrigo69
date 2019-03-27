using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//clase para el movimiento del heroe
public class Movimiento_Heroe : MonoBehaviour
{
    //se crea un struct para almacenar los atributos de la clase
    struct InformacionDeHeroe
    {
        public float velocidad;
        public float velocidad_Contenida;
    }
    
	
	void Start ()
    {
        //se definen algunas variables
        VariablesDeMovimientoHeroe.velocidad = Random.Range(1.0f, 2f);
        VariablesDeMovimientoHeroe.velocidad_Contenida = VariablesDeMovimientoHeroe.velocidad;
    }
	
	
	void Update ()
    {
        //se llama la funcion para que se ejecute cada frame
        MovimientoHeroe();
	}
    //se crea la funcion
    public void MovimientoHeroe()
    {
        //se ponen los condicionales que indican que hacer cuando se presione una tecla
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += this.transform.forward * VariablesDeMovimientoHeroe.velocidad;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                VariablesDeMovimientoHeroe.velocidad = 3f;
            }
            else
            {
                VariablesDeMovimientoHeroe.velocidad = VariablesDeMovimientoHeroe.velocidad_Contenida;
            }
        }
        else
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * VariablesDeMovimientoHeroe.velocidad;
            print("s");
        }
        else
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position -= this.transform.right * VariablesDeMovimientoHeroe.velocidad;
        }
        else
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += this.transform.right * VariablesDeMovimientoHeroe.velocidad;
        }
    }
    InformacionDeHeroe VariablesDeMovimientoHeroe;
}