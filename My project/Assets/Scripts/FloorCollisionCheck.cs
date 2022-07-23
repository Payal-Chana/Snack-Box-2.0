using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollisionCheck : MonoBehaviour
{
    public GameObject Halo, StringLights, Paperclip, Lasso;
    public bool canMakeLasso, gotHalo, gotpaperclip, gotStringLights;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gotHalo == true && gotpaperclip == true && gotStringLights == true)
        {
            canMakeLasso = true;
            Halo.SetActive(false);
            Paperclip.SetActive(false);
            StringLights.SetActive(false);
            Lasso.SetActive(true);

            //Sound for object placed down
            //FindObjectOfType<MusicManager>().Play("Lasso");
            
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Halo")
        {
            Debug.Log("Halo Collided");
            gotHalo = true;
        }
        if (other.gameObject.name == "String Lights")
        {
            Debug.Log("String Lights Collided");
            gotStringLights = true;
        }
        if (other.gameObject.name == "Paperclip")
        {
            Debug.Log("Paperclips Collided");
            gotpaperclip = true;
        }

    }
}
