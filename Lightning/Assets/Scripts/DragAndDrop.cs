using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 mousePosition;
    private Color col;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }
    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
        GetComponent<Rigidbody>().isKinematic = true; //Wird hier nicht von anderen objekten beeinflusst
        //färbt das objekt
        if (GetComponent<MeshRenderer>() != null )
        {
            col = GetComponent<MeshRenderer>().material.color; //farbe gespeichert
            GetComponent<MeshRenderer>().material.color = Color.yellow; //farbe umändern
        }
    }
    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition); //gleichsetzen des objects mit der maus
    }
    private void OnMouseUp()
    {
        GetComponent<Rigidbody>().isKinematic = false;
        if (GetComponent<MeshRenderer>() != null)
        {
            col = GetComponent<MeshRenderer>().material.color = col; //farbe zurück bringen 
           
        }
    }

}

