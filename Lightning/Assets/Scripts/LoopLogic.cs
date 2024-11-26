using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopLogic : MonoBehaviour
{
    public GameObject[] cubes;

    void Awake() //passiert beim start
    {
        cubes = GameObject.FindGameObjectsWithTag("MyCube");
    }
    public void StartLoops()
    {
        ChangeColors();
    }
    void ChangeColors()
    {
        for (int i = 0; i < cubes.Length; i++) //foreach loop
        {
            MeshRenderer cubeRenderer = cubes[i].GetComponent<MeshRenderer>(); //jeder würfel
            cubeRenderer.material.color = Random.ColorHSV(); //gibt die farbe
          //GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); //gibt eine random color
        }


    }
    void MoveUp() //da kommt das foreach rein
    {
        //transform.position += new Vector3(0, 1.5f, 0);

        foreach(GameObject cube in cubes)
        {
            cube.transform.position += new Vector3(0, 1.5f, 0);
        }
    }
}
