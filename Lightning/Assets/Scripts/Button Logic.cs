using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


//Implementieren von den Methoden (Save, Load, Delete (cleart UI und PlayerPrefs)) mit Playerprefs + verknüpfen
// Set = save, Get = load, Delete = löschen
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





