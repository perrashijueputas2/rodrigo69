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
    List<Cuenta> cuentas = new List<Cuenta>();
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
                Cuenta miCuenta = new Cuenta(Nombre.text, System.Convert.ToDouble(Saldo.text));
                Guia.text = "La cuenta" + " ha sido creada";
                cuentas.Add(miCuenta);
                count++;
            }
            else
            {
                Guia.text = "no me jodas con tu cuenta mugrienta";
            }
        }
        else
        {
            Cuenta miCuenta = new Cuenta(Nombre.text);
            Guia.text = "La cuenta " + count + " ha sido creada";
            cuentas.Add(miCuenta);
            count++;
        }
    }
    public void BuscarCuenta()
    {
        
        foreach (Cuenta cuentica in cuentas)
        {
            if (cuentica.GetTitular() == BuscadorCuenta.text)
            {
                MostrarDatos.text = "Titular " + cuentica.GetTitular() + "Saldo: " + cuentica.GetSaldo();
            }
        }
    }
    public void ConsignarEnCuenta()
    {
        foreach (Cuenta cuentica in cuentas)
        {
            if (cuentica.GetTitular() == BuscadorCuenta.text)
            {
                if (System.Convert.ToDouble(ValorACambiar.text) > 0)
                {
                    cuentica.Ingresar(System.Convert.ToDouble(ValorACambiar.text));
                }
                else
                {
                    Guia.text = "ni lo intentes, prro";
                }
                
            }
        }
    }
    public void RetirarEnCuenta()
    {
        foreach (Cuenta cuentica in cuentas)
        {
            if (cuentica.GetTitular() == BuscadorCuenta.text)
            {
                if (System.Convert.ToDouble(ValorACambiar.text) > 0)
                {
                    cuentica.Retirar(System.Convert.ToDouble(ValorACambiar.text));

                }
                else
                {
                    Guia.text = "ni lo intentes, prro";
                }
                
            }
        }
    }
}