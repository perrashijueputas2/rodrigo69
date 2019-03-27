using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reja : MonoBehaviour
{
    int x;
    int y;
    public bool Generar;


     public void Update()
     {
        if (Generar == true)
        {
            x = Random.Range(3, 13);
            y = Random.Range(3, 13);
             for (int i = 0; i < x; i++)
             {
                for (int j = 0; j < y; j++)
                {
                    GameObject Caja = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    Caja.transform.position = new Vector2(i * 2, j * 2);

                    
                    int colorAleatorio = Random.Range(1,5);

                   switch (colorAleatorio)
                   {

                    case 1:

                        Caja.GetComponent<MeshRenderer>().material.color = Color.red;

                        break;

                    case 2:

                        Caja.GetComponent<MeshRenderer>().material.color = Color.yellow;

                        break;

                    case 3:

                        Caja.GetComponent<MeshRenderer>().material.color = Color.green;

                        break;

                    case 4:

                        Caja.GetComponent<MeshRenderer>().material.color = Color.blue;

                        break;


                   }
                }
             }
            Generar = false;
        }
     }
}
