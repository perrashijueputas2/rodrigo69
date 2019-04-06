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
    Cuenta[] cuentas = new Cuenta[3];
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
            Cuenta miCuenta = new Cuenta(Nombre.text, System.Convert.ToDouble(Saldo.text));
            Guia.text = "La cuenta " + count + " ha sido creada";
            cuentas[count] = miCuenta;
            count++;
        }
        else
        {
            Cuenta miCuenta = new Cuenta(Nombre.text);
            Guia.text = "La cuenta " + count + " ha sido creada";
            cuentas[count] = miCuenta;
            count++;
        }
        if (count == cuentas.Length)
        {
            Guia.text = "se ha creado la ultima cuenta posible";
        }
    }
    public void BuscarCuenta()
    {
        
        Cuenta ct = cuentas[System.Convert.ToInt32(BuscadorCuenta.text)];
        MostrarDatos.text = "Titular: "+ct.GetTitular() +"        Saldo: "+ ct.GetSaldo();
    }
}