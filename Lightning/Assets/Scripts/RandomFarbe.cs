using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFarbe : MonoBehaviour
{
    private Farben farben;

    private void Awake() //Initialisieren
    {
        farben = GameObject.Find("Logic").GetComponent<Farben>();
    }
    void Start() //passiert beim start
    {
        GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); //gibt eine random color

    }
    private void OnMouseDown() // passiert ab anklicken der maus
    {
        farben.AddColorToList(GetComponent<MeshRenderer>().material.color); //rufen vom anderen script die void ab und das ist diese farbe
        //print(GetComponent<MeshRenderer>().material.color); //Die farbe
        Destroy(gameObject); // Das zerstört 
    }
    
    
  
    
}