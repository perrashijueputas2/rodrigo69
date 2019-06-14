using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vuelta : MonoBehaviour
{

    void Start()
    {
      
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.eulerAngles += new Vector3(0, 5, 0);
        }
    }
}
