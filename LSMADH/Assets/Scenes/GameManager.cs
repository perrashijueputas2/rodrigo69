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
    int count;
    Cuenta[] cuentas = new Cuenta[2];
    private void Start()
    {
        count = 0;
        
    }
    private void Update()
    {
        if (count < cuentas.Length)
        {
            
            if (Input.GetKeyDown(KeyCode.S))
            {
                Debug.Log("Ingrese la cantidad");
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                Debug.Log("Presione guardar cuenta");

            }
        }
    }
    //strin.isnullorempty
    public void DecidirGuardado()
    {
        if (!string.IsNullOrEmpty(Saldo.text))
        {
            Cuenta micuenta = new Cuenta(Nombre.text, System.Convert.ToDouble(Saldo.text));
            Debug.Log("La cuenta con saldo ha sido creada");
            Saludo();
        }
        else
        {
            Cuenta micuenta = new Cuenta(Nombre.text);
            Debug.Log("La cuenta sin saldo ha sido creada");
            Saludo();
        }
    }
    public void Saludo()
    {
        if (count < cuentas.Length)
        {
            Debug.Log("Buenas buenas, éste es el creador de cuentas");
            Debug.Log("Ingrese nombre del titular");
            Debug.Log("Desea Crear cuenta con saldo? s = si, n = no");
        }
        else
        {
            Debug.Log("no tenemos capacidad prro :´v");
        }
    }
    public void Main()
    {
        
        
        //Cuenta miCuenta;

        
        //else
        //{
        //    miCuenta = new Cuenta(nombre);
        //}
        //cuentas[count] = miCuenta;
        //count++;
    }
}