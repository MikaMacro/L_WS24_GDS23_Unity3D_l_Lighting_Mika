using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farben : MonoBehaviour
{
    public List<Color> color = new List<Color>();
    public int maxColors = 3;
    public GameObject[] colorArray;

    private void Start()
    {
        colorArray = GameObject.FindGameObjectsWithTag("Sphere");
        AddColorToList();
    }
    public void AddColorToList()
    {
        //color.Add();

    }
}
