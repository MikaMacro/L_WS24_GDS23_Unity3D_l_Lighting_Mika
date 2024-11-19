using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player; // Gameobject f�r den player machen

    public void Save() //saved
    {
        PlayerPrefs.SetFloat("PositionX", player.transform.position.x); //bestimmt + gibt namen der positionen
        PlayerPrefs.SetFloat("PositionY", player.transform.position.y);
        PlayerPrefs.SetFloat("PositionZ", player.transform.position.z);
    }
    public void Load() // l�d  
    {
        Vector3 XYZ = new Vector3(PlayerPrefs.GetFloat("PositionX"), PlayerPrefs.GetFloat("PositionY"), PlayerPrefs.GetFloat("PositionZ"));
        //Auf Vector 3 ist (name) XYZ genauso wie, eine float f�r X Y und Z 
        player.transform.position = XYZ; //sagt, das es f�r die XYZ achse gilt 
    }

}
