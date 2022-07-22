using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassetteControllerScript : MonoBehaviour
{
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public bool isCollided;
    public GameObject CassetteSlot;
    public BoxCollider2D playerCollider;
    
    private void Update()
    {
        if (isCollided == true)
        {
            audio2.enabled = false;
            audio3.enabled = false;
            //this.gameObject.transform.position = CassetteSlot.transform.position;
        }
        else
        {
            audio2.enabled = true;
            audio3.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cassette Player")
        {
            isCollided = true;
            audio1.Play();
            audio1.enabled = true;
            //StartCoroutine("waitForSecs");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cassette Player")
        {
            isCollided = false;
            audio1.enabled = false;
        }
    }

    IEnumerator waitForSecs()
    {
        yield return new WaitForSeconds(2);
        
        playerCollider.enabled = false;
    }
}
