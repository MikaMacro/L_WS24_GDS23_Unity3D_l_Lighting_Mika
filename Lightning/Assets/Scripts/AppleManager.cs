using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AppleManager : MonoBehaviour
{
    public float time = 0;
    public TMP_Text timetime;
    [SerializeField] public int numberToCollect = 8;
    public TMP_Text points;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Frage ob es Player ist
        if (numberToCollect == 0)
        {
            //SceneChange
            SceneManager.LoadScene("DoneScreen");
           
        }
    }
    public static void Restart()
    {
        SceneManager.LoadScene("AppelUebung");
    } 
    public void SaveData() // Saved button

    {

        //PlayerPrefs.SetString("Input", time = TMP_Text.printtimetime ); //speichert den eingeschriebenen text
        PlayerPrefs.Save(); //Saved direkt auch nach löschen
    }
    private void Update()
    {
        time = Time.time;
        timetime.text = time.ToString();
    }
   
}
