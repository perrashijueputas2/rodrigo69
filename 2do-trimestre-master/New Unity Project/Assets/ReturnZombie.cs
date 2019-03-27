using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnZombie : MonoBehaviour
{

	Zombie GetZombie()
    {
        return (Zombie) GameObject.FindObjectOfType(typeof(Zombie));
    }


    private void Update()
    {
        Zombie target = GetZombie();
        if(target != null)
        {

              Debug.DrawLine(transform.position, GetZombie().transform.position, Color.red);

        }
      
    }


}
