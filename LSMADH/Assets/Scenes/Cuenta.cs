﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cuenta
{

    private double saldo;
    private string titular;
    public double GetSaldo()
    {
        return saldo;
    }
    public void SetSaldo(double _saldo)
    {
        this.saldo = _saldo;
    }
    public string GetTitular()
    {
        return titular;
    }
    public void SetTitular(string _titular)
    {
        this.titular = _titular;
    }
    public void Ingresar(double _valorAIngresar)
    {
        //SetSaldo = 
    }
    public void Retirar(double _valorARetirar)
    {
        Debug.Log("solo pudiste retirar " + saldo);
        Debug.Log("retiraste " + " y te quedó " + saldo + " en tu cuenta");
        saldo = 0;
    }
    public Cuenta(string _nombre, double _saldo)
    {
        this.saldo = _saldo;
        this.titular = _nombre;
    }
    public Cuenta(string _nombre)
    {
        this.titular = _nombre;
    }
}
