using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class ButtonPosition : MonoBehaviour
{
    public GameObject player; //sphere

    public void Save() //saved Button
    {
        PlayerPrefs.SetFloat("PositionX", player.transform.position.x); 
        PlayerPrefs.SetFloat("PositionY", player.transform.position.y); //positionen
        PlayerPrefs.SetFloat("PositionZ", player.transform.position.z);
        
    }
    public void Load() // läd  Button
    {
        //Vector3 XYZ = new Vector3(PlayerPrefs.GetFloat("PositionX"), PlayerPrefs.GetFloat("PositionY"), PlayerPrefs.GetFloat("PositionZ"));
        //Auf Vector 3 ist (name) XYZ genauso wie, eine float für X Y und Z 
        //player.transform.position = XYZ; //sagt, das es für die XYZ achse gilt

        if (PlayerPrefs.HasKey("player.transform.position.x"))
        {
            Vector3 XYZ = new Vector3(PlayerPrefs.GetFloat("PositionX"), PlayerPrefs.GetFloat("PositionY"), PlayerPrefs.GetFloat("PositionZ"));
            player.transform.position = XYZ;
            
        }
        else
        {
           print("NoPositionSaved");
        }
        
    }
    
}
