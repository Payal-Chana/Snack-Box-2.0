using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashColliderController : MonoBehaviour
{
    public Animator trashAnim;
    public GameObject newPos;
    
    public CounterObjectsManager counter;
    
    private void Start()
    {
        trashAnim.SetBool("thrown", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trash")
        {
            trashAnim.SetBool("thrown", true);

            //this.gameObject.SetActive(false);
            
            //Sound for trash
            FindObjectOfType<MusicManager>().Play("Trash");

            counter.FoundCounter++;

            StartCoroutine("waitForAnim");
        }
    }

    IEnumerator waitForAnim()
    {
        yield return new WaitForSeconds(0.5f);
        trashAnim.SetBool("thrown", false);
        this.gameObject.transform.position = newPos.transform.position;
    }
}
