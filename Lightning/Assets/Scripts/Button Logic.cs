using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


//Implementieren von den Methoden (Save, Load, Delete (cleart UI und PlayerPrefs)) mit Playerprefs + verkn�pfen
// Set = save, Get = load, Delete = l�schen
//Man kann nur float strings und ints speichern, eine bool kann man mit true oder false schreiben 

public class ButtonLogic : MonoBehaviour
{
    public TMP_InputField inputField; //was hole ich mir
    public void SaveData()

    {
        
        PlayerPrefs.SetString("Input", inputField.text); //speichert text
        PlayerPrefs.Save();
    }
    public void LoadData()
    {
        //print(PlayerPrefs.GetString("Input")); //l�st ihn neu laden
        inputField.text = PlayerPrefs.GetString("Input");
    }
    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("Input"); //l�scht alles
        inputField.text = string.Empty; // + l�scht nur text
        //PlayerPrefs.DeleteAll();
    }

    
}





