using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour, IInteractuable
{
    public void Interact()
    {
        gameObject.SetActive(false);
    }
}
