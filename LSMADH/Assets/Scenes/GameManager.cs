using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public InputField Saldo;
    public InputField Nombre;
    public Button Limpiar;
    public Button MostrarCuentaAnterior;
    public Button GuardarCuenta;
    private Cuenta[] cuentas = new Cuenta[10];
    public string nombreTemporal;
    public float temporal;
    private void Start()
    {
    }
    private void Update()
    {
        
    }
    void GuardarCuentaNueva()
    {
        Cuenta CuentaNueva = new Cuenta(Nombre.text , System.Convert.ToDouble(Saldo.text));
        
    }
}