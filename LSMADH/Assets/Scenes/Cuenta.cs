using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cuenta : MonoBehaviour {
    string titular;
    double dinero;
    string vacio;
    void Start()
    {
        

        //public float temporal = System.Convert.ToSingle()
    }


    void Update()
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
    public double GetDinero()
    {
        return dinero;
    }
    public void SetDinero(float Dinero)
    {
        this.dinero = Dinero;
    }

    public void Ingresar(double _cantidad)
    {
        if (_cantidad > 0)
        {
            dinero += (float)_cantidad;
        }
    }
    public void Retirar(double _cantidad)
    {
        if (_cantidad<0)
        {

        }
    }
    public Cuenta(string _titular, double _saldo)
    {
        titular = _titular;
        dinero = _saldo;
    }
    public Cuenta(string _titular)
    {
        titular = _titular;
    }
}
