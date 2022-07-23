using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsClickAndDrag : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool hasBeenClicked;
    public GameObject theCamera;

    public GameObject item;
    public bool goalPosFound;
    public GameObject snappingPos;

    public Text L_Text, A_Text, S1_Text, S2_Text, O_Text;
    public GameObject EnterKey, Hint, VinylDisk;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.bodyType = RigidbodyType2D.Dynamic;
        if (goalPosFound == true)
        {
            this.gameObject.transform.position = snappingPos.transform.position;
        }

        if (gameObject.name == "L" && goalPosFound == true)
        {
            L_Text.gameObject.SetActive(true);
        }
        if (gameObject.name == "A" && goalPosFound == true)
        {
            A_Text.gameObject.SetActive(true);
        }
        if (gameObject.name == "S" && goalPosFound == true)
        {
            S1_Text.gameObject.SetActive(true);
            S2_Text.gameObject.SetActive(true);
        }
        if (gameObject.name == "O" && goalPosFound == true)
        {
            O_Text.gameObject.SetActive(true);
        }
        if (L_Text.gameObject.activeSelf == true &&
            A_Text.gameObject.activeSelf == true &&
            S1_Text.gameObject.activeSelf == true &&
            S2_Text.gameObject.activeSelf == true &&
            O_Text.gameObject.activeSelf == true)
        {
            if (gameObject.name == "Wifi" && goalPosFound == true)
            {
                EnterKey.SetActive(true);
                Hint.SetActive(true);
            }  
        }
    }

    private void OnMouseDown()
    {
        if (gameObject.name == "Enter")
        {
            Debug.Log("It works");
            //Set active the hint
        }
        else
        {
            if (gameObject.name != "String Lights")
            {
                rb.bodyType = RigidbodyType2D.Dynamic;
                gameObject.transform.parent = theCamera.transform;
                gameObject.layer = 0;
            }
        }
    }

    private void OnMouseUp()
    {
        gameObject.layer = 6;
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.bodyType = RigidbodyType2D.Kinematic;
        Debug.Log("They Collided");

        /*if (gameObject.name == "String Lights" && collision.gameObject.name == "Vinyl Disk")
        {
            VinylDisk.SetActive(false);
        }*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == this.gameObject.name && gameObject.layer == 0)
        {
            //trashAnim.SetBool("inPlace", true);
            goalPosFound = true;
            //Sound for object placed down
            FindObjectOfType<MusicManager>().Play("ObjectPlacedDown");
        }

        if (gameObject.name == "String Lights" && collision.gameObject.name == "Vinyl Disk")
        {
            VinylDisk.SetActive(false);
            rb.bodyType = RigidbodyType2D.Dynamic;
            gameObject.transform.parent = theCamera.transform;
            gameObject.layer = 0;
        }
        else if (gameObject.name == "String Lights")
        {
            rb.bodyType = RigidbodyType2D.Static;
        }
           
    }
}
