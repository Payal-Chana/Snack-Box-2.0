using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectsTrayController : MonoBehaviour
{
    //public Animator ObjectAnim;
    public GameObject Object;
    public bool trayPosFound;
    public GameObject trayRightPos;
    public BoxCollider2D collider;
    
    public CounterObjectsManager counter;
    
    private void Update()
    {
        if (trayPosFound == true)
        {
            this.gameObject.transform.position = trayRightPos.transform.position;
            collider.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == this.gameObject.name)
        {
            //trashAnim.SetBool("inPlace", true);
            trayPosFound = true;
            //Sound for object placed down
            FindObjectOfType<MusicManager>().Play("ObjectPlacedDown");
            
            counter.FoundCounter++;
        }
    }
    
}
