using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;

    public void Save()
    {
        PlayerPrefs.SetFloat("PositionX", player.transform.position.x);
        PlayerPrefs.SetFloat("PositionY", player.transform.position.y);
        PlayerPrefs.SetFloat("PositionZ", player.transform.position.z);
    }
    public void Load()
    {
        Vector3 XYZ = new Vector3(PlayerPrefs.GetFloat("PositionX"), PlayerPrefs.GetFloat("PositionY"), PlayerPrefs.GetFloat("PositionZ"));
        player.transform.position = XYZ;
    }

}
