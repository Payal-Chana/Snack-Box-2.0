using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashColliderController : MonoBehaviour
{
    public Animator trashAnim;
    
    private void Start()
    {
        trashAnim.SetBool("thrown", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trash")
        {
            trashAnim.SetBool("thrown", true);

            this.gameObject.SetActive(false);

            //Sound for trash
            FindObjectOfType<MusicManager>().Play("Trash");
        }
    }
}
