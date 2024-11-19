using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;

public class ColorSave : MonoBehaviour
{
    private Color color;
    private string colorString;

    public void Save()
    {
        color = GetComponent<MeshRenderer>().material.color;
        colorString = ColorUtility.ToHtmlStringRGBA(color);
        PlayerPrefs.SetString("colorString", colorString);
        PlayerPrefs.Save();
    }
    public void Load()
    {
        colorString = PlayerPrefs.GetString("colorString");
        

        if (ColorUtility.TryParseHtmlString("#" + colorString, out color))
        {
            GetComponent<MeshRenderer>().material.color = color;
        }
        else
        {
            print("Error to set color:");
        }
       
    }
}
