using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


//Implementieren von den Methoden (Save, Load, Delete (cleart UI und PlayerPrefs)) mit Playerprefs + verknüpfen
// Set = save, Get = load, Delete = löschen
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
        //print(PlayerPrefs.GetString("Input")); //läst ihn neu laden
        inputField.text = PlayerPrefs.GetString("Input");
    }
    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("Input"); //löscht alles
        inputField.text = string.Empty; // + löscht nur text
        //PlayerPrefs.DeleteAll();
    }

    
}





