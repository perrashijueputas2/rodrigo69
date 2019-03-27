using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cuenta : MonoBehaviour {
    string titular;
    int dinero;
    
    string vacio;
    //int DiasDesdeRegistro = Random.Range(0, 2000);
    void Start()
    {
        

        //public float temporal = System.Convert.ToSingle()
    }


    void Update()
    {
    }
    public void CuentaAnterior()
    {
        Debug.Log("la cuenta anterior fue " + titular + ", y su saldo es " + dinero);

    }
    public void LimpiarCuenta()
    {
        Nombre.text = "";
        
    }
    public void GuardarEnAlmacen()
    {

    }
   

    public string GetTitular()
    {
        return titular;
    }
    public void SetTitular(string Titular)
    {
        this.titular = Titular;
    }
    public int GetCantidad()
    {
        return dinero;
    }
    public void SetCantidad(int Cantidad)
    {
        this.dinero = Cantidad;
    }

    public void Ingresar(double _cantidad)
    {
        if (_cantidad > 0)
        {
            dinero += (int)_cantidad;
        }
    }
    public void Retirar(double _cantidad)
    {
        //int cantidad - _cantidad = cantidad;
    }

}
