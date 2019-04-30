using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Correr : MonoBehaviour
{
    public GameObject cc;
    public Image Cora;
    public Text cama;
    int vida = 2;


    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        vida = vida - 1;
       if(vida == 1)
        {
            Debug.Log("Auch");
            cama.text = " " + vida;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        cc.transform.Translate(0.5f, 0f, 0f);
    }
}
