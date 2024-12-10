using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    private AppleManager appleManager;

    private void Awake()
    {
        appleManager = GameObject.Find("AppleManager").GetComponent<AppleManager>();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            Destroy(collision.gameObject);
            appleManager.numberToCollect--;
            if (appleManager.numberToCollect == 0)
            {
                appleManager.DoneScreen.SetActive(true);

            }

            appleManager.points.text = appleManager.numberToCollect.ToString();
        }
    }
}
