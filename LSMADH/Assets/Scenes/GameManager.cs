using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public InputField Saldo;
    public InputField Nombre;
    public Button MostrarCuentaAnterior;
    public Button GuardarCuenta;
    public Button Buscar;
    public Button Consignar;
    public Button Retirar;
    public InputField ValorACambiar;
    int count;
    public Text Guia;
    public Text MostrarDatos;
    public InputField BuscadorCuenta;
    //List<Cuenta> cuentas = new List<Cuenta>();
    Dictionary<string, Cuenta> Diccionarioprron = new Dictionary<string, Cuenta>();
    private void Start()
    {
        count = 0;
        Guia.text = "Buenas buenas, éste es el creador de cuentas, ingrese nombre del titular y si desea un saldo, de lo contrario presione guardar.";
    }
    private void Update()
    {
    }
    //strin.isnullorempty
    public void Guardado()
    {
        if (!string.IsNullOrEmpty(Saldo.text))
        {
            if (System.Convert.ToInt32( Saldo.text) > 0)
            {
                Cuenta cuentaTemporal = new Cuenta(Nombre.text, System.Convert.ToDouble(Saldo.text));
                Diccionarioprron.Add(Nombre.text, cuentaTemporal);
                Guia.text = "La cuenta" + " ha sido creada";
            }
            else
            {
                Guia.text = "no me jodas con tu cuenta mugrienta";
            }
        }
        else
        {
            Cuenta cuentaTemporal = new Cuenta(Nombre.text);
            Diccionarioprron.Add(Nombre.text, cuentaTemporal);
            Guia.text = "La cuenta " + " ha sido creada";
            count++;
        }
    }
    public void BuscarCuenta()
    {

        if (Diccionarioprron.ContainsKey(BuscadorCuenta.text))
        {
            Cuenta cuentatemp = Diccionarioprron[BuscadorCuenta.text];
            MostrarDatos.text = "Titular: " + cuentatemp.GetTitular() + "saldo: " + cuentatemp.GetSaldo();
        }
        else
        {
            Debug.Log("esa tal cuenta no existe");
        }
  

    }
    public void ConsignarEnCuenta()
    {
        Cuenta cuentatemp = Diccionarioprron[BuscadorCuenta.text];
        if (System.Convert.ToDouble(ValorACambiar.text) > 0)
        {
            cuentatemp.Ingresar(System.Convert.ToDouble(ValorACambiar.text));

        }
        else
        {
            Guia.text = "ni lo intentes, prro";
        }
    }
    public void RetirarEnCuenta()
    {
        Cuenta cuentatemp = Diccionarioprron[BuscadorCuenta.text];
        if (System.Convert.ToDouble(ValorACambiar.text) > 0)
        {
            cuentatemp.Retirar(System.Convert.ToDouble(ValorACambiar.text));

        }
        else
        {
            Guia.text = "ni lo intentes, prro";
        }
    }
}