using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnackNames : MonoBehaviour
{
    private Vector3 mouseOffset;
    private float mouseZCoord;
    public GameObject Kokopop, Pringle, Cheese;

    private void OnMouseDown()
    {
        mouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        //mOffset = gameObject world pos - OnMouseDown world pos
        mouseOffset = gameObject.transform.position - MouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + mouseOffset;
    }

    private Vector3 MouseWorldPosition()
    {
        //pixel coordinates (x,y)
        Vector3 mousePoint = Input.mousePosition;

        //z coordinate of game object of screen
        mousePoint.z = mouseZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Trigger Name")
        {
            if (gameObject.name == "Kokopop")
            {
                Kokopop.SetActive(true);
                Cheese.SetActive(false);
                Pringle.SetActive(false);
            }
            
            if (gameObject.name == "Cheese")
            {
                Cheese.SetActive(true);
                Pringle.SetActive(false);
                Kokopop.SetActive(false);
            }
            
            if (gameObject.name == "Pringle")
            {
                Pringle.SetActive(true);
                Cheese.SetActive(false);
                Kokopop.SetActive(false);
            }
            //trashAnim.SetBool("inPlace", true);

            //Sound for object placed down
            //FindObjectOfType<MusicManager>().Play("ObjectPlacedDown");
        }
    }

}
