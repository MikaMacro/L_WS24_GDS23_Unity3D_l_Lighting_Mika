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
    public TMP_InputField inputField; //was ich mir hole (text)
    public void SaveData() // Saved button

    {
        
        PlayerPrefs.SetString("Input", inputField.text); //speichert den eingeschriebenen text
        PlayerPrefs.Save(); //Saved direkt auch nach l�schen
    }
    public void LoadData() // l�d gel�schten text
    {
        //print(PlayerPrefs.GetString("Input")); //l�st ihn neu laden (kann man raus nehmen)
        inputField.text = PlayerPrefs.GetString("Input"); // input (in klammern das) ist der name
    }
    public void DeleteData() //L�scht den text
    {
        PlayerPrefs.DeleteKey("Input"); //l�scht alles
        inputField.text = string.Empty; // + l�scht nur text
        //PlayerPrefs.DeleteAll();
    }

    
}





