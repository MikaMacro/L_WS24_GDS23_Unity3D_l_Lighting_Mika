using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoopLogic : MonoBehaviour
{
    public GameObject[] cubes;
    //public Toggle scaleToggle;
    private int count = 10;

    void Awake() //passiert beim start
    {
        cubes = GameObject.FindGameObjectsWithTag("MyCube");
    }
    public void StartLoops()
    {
        ChangeColors();
        MoveUp();
        Shrink();
        print();
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
    private void Shrink() //while schleife
    {
        while(count > 0)
        {
            count--;
            
            foreach (GameObject cube in cubes)
            {
                if(cube.transform.localScale.x > 0.1f)
                {
                  cube.transform.localScale *= 0.9f; //-= new Vector3(0.1f, 0.1f, 0.1f);
                }
                
            }
        }
    }
    private void print()
    {
        do
        {
            print("Message");
        }
        while (count > 0);
        

        
    }
}
