using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClickandDrag : MonoBehaviour
{
    private Vector3 mouseOffset;
    private float mouseZCoord;

    private void OnMouseDown()
    {
        //Sound for object interactable
        FindObjectOfType<MusicManager>().Play("ObjectInteractable");
        
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

}
