using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    private AudioSource explodison;
    private void Awake()
    {
        explodison = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
          Destroy(collision.gameObject);
        explodison.Play();
        } 
    }
}
