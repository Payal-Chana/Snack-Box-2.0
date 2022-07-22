using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsClickAndDrag : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool hasBeenClicked;
    public GameObject theCamera;

    public GameObject item;
    public bool goalPosFound;
    public GameObject snappingPos;
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
    }

    private void OnMouseDown()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        gameObject.transform.parent = theCamera.transform;
        gameObject.layer = 0;
    }

    private void OnMouseUp()
    {
        gameObject.layer = 6;
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.bodyType = RigidbodyType2D.Kinematic;
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
    }
}
