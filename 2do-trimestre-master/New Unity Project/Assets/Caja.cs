using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caja : MonoBehaviour {

    int numCajas = 0;
	
	void Update ()
    {
		while (numCajas < 10)
        {
            GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
            box.transform.position = new Vector3(numCajas * 2.0f, 0f, 0f);
            numCajas++;
        }
	}
}
