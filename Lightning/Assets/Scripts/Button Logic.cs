using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


//Implementieren von den Methoden (Save, Load, Delete (cleart UI und PlayerPrefs)) mit Playerprefs + verkn�pfen
// Set = save, Get = load, Delete = l�schen
//

public class ButtonLogic : MonoBehaviour
{
    public TMP_InputField inputField;
    public void SaveData()
    {
        
        PlayerPrefs.SetString("Input", inputField.text);
        
    }
    public void LoadData()
    {
        PlayerPrefs.GetString("Input");
    }
    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("Input");
        inputField.text = string.Empty;
        //PlayerPrefs.DeleteAll();
    }
}





