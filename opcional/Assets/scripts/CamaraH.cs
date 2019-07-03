using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraH : MonoBehaviour
{
    //float mouseX;
    //float mouseY;
    //public bool invertirMouse;
    //public float velocidad = 1f;
    //public float rotateSpeed = 3.0f;
    //CharacterController controller;
    //public GameObject cam;
    //public float rot_x;
    //private void Start()
    //{
    //    invertirMouse = false;
    //}

    void Update()
    {
        Movimiento();
        //    RotacionCamara();
    }
    void Movimiento()
    {
        float pointer_x = Input.GetAxis("Mouse Y");
        float pointer_y = Input.GetAxis("Mouse X");
        transform.Rotate(0, -pointer_y * -1.5f, 0);
    }
    //void RotacionCamara()
    //{
    //    GetComponentInChildren<Camera>().transform.eulerAngles = new Vector3( mouseX, mouseY, 0);
    //    mouseX += Input.GetAxis("Mouse X");
    //    if (invertirMouse)
    //    {
    //        mouseY += Input.GetAxis("Mouse Y");
    //    }
    //    else
    //    {
    //        mouseY -= Input.GetAxis("Mouse Y");
    //    }
    //    transform.eulerAngles = new Vector3();

    //}
    //public void Movimiento()
    //{
    //    transform.Rotate(0, Input.GetAxis("Mouse X") * rotateSpeed, 0);


    //    rot_x += (Input.GetAxis("Mouse Y") * -1) * rotateSpeed;

    //    if (rot_x > 0 && rot_x < 60)
    //    {
    //        cam.transform.localRotation = Quaternion.Euler(rot_x, 0, 0);
    //    }
    //    if (rot_x < 0 && rot_x > -60)
    //    {
    //        cam.transform.localRotation = Quaternion.Euler(rot_x, 0, 0);
    //    }
    //    if (rot_x > 60)
    //    {
    //        rot_x = 60;
    //    }
    //    if (rot_x < -60)
    //    {
    //        rot_x = -60;
    //    }

    //    Vector3 forward = transform.TransformDirection(Vector3.forward);
    //    float curSpeed = velocidad * Input.GetAxis("Vertical");
    //}
}
