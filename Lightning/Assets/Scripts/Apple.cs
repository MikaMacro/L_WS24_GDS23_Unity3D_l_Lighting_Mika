using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private Farben farben;
    private void Awake() //Initialisieren
    {
        farben = GameObject.Find("Apple").GetComponent<Farben>();
    }
    void Start() //passiert beim start
    {
        GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); //gibt eine random color

    }
    
}
