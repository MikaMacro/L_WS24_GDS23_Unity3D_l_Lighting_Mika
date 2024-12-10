using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject gamepadPrefab;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate(gamepadPrefab, gameObject.transform.position, Quaternion.identity); // Das ist das die auf dem spwan point spawnen der schoon festgelegt ist
            Instantiate(gamepadPrefab, new Vector3(Random.Range(-5f, 8f),3,Random.Range(-3.5f, -11.5f)), Quaternion.identity); //Das ist für eine random Range in der welt 
        }
    } //-5 und -3.5 x und z
      //8 und -11.5 x und z
}
