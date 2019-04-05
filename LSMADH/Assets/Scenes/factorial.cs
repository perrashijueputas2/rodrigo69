using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factorial : MonoBehaviour
{
    public double fact;
    public double regresion;
    public double vi;

    public double resultado;
    public double resultadof;
    // Start is called before the first frame update
    void Start()
    {
        vi = fact;
        for (double i = fact; i > 0; i--)
        {
            fact--;
            resultado = vi * fact;
            print(resultado);

        }
        resultadof = resultado;
        

    }

    // Update is called once per frame
    void Update()
    {
    }
}
