using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSAim : MonoBehaviour
{
    public bool InvertedMouse;
    float mouseX;
    float mouseY;
    private void Start()
    {
        transform.eulerAngles = new Vector3(30, 0, 0);
    }



    private void Update ()
    {

        mouseX += Input.GetAxis("Mouse X");
       if (InvertedMouse)
        {
            mouseY += Input.GetAxis("Mouse Y");
        }else
        {
            mouseY -= Input.GetAxis("Mouse Y");
        }
            
        transform.eulerAngles = new Vector3( mouseY, mouseX, 0);
        Debug.Log("Mouse X:"+ mouseX + "Mouse Y:"+ mouseY);



    }
}
