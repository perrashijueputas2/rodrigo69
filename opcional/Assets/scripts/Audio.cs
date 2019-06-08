using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioSystem2D.Instance.PlayMusic(songName: "Ambiente");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
