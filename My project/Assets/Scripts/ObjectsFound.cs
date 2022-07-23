using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectsFound : MonoBehaviour
{
    public int FoundCounter = 0;
    public int finalNumberOfObjectsFound;
    public GameObject StarPanel;
    
    public GameObject Object;
    public bool trayPosFound;
    public GameObject trayRightPos;
    public BoxCollider2D collider;

    private void Start()
    {
        //trashAnim.SetBool("inPlace", false);
        
    }

    private void Update()
    {
        if (trayPosFound == true)
        {
            this.gameObject.transform.position = trayRightPos.transform.position;
            collider.enabled = false;
        }
        
        if (FoundCounter >= finalNumberOfObjectsFound)
        {
            StartCoroutine("starPanel");
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

            FoundCounter++;
        }
    }

    IEnumerator starPanel()
    {
        yield return new WaitForSeconds(2);
        StarPanel.SetActive(true);
        yield return new WaitForSeconds(2);
        //SceneManager.LoadScene("Credits");
    }
}
