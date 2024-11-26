using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farben : MonoBehaviour
{
    public List<Color> colorList = new List<Color>();
    public int maxColors = 3;
    public GameObject[] colorArray;

    private void Start()
    {
        colorArray = GameObject.FindGameObjectsWithTag("Sphere");
        //AddColorToList();
    }
    public void AddColorToList(Color color)
    {
        colorList.Add(color);
        if (colorList.Count == maxColors)
        {
           foreach(Color colors3 in colorList)
            {
                print(colors3);
            }
        }
    }
}
