using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject theCamera;
    public GameObject startPos;
    public GameObject endPos;
    public float speed = 0.5f;

    public Animator AnimGameObjects;
    public Animator AnimTexts;
    
    // Start is called before the first frame update
    void Start()
    {
        theCamera.transform.position = startPos.transform.position;
        AnimGameObjects.SetBool("isShaking", false);
        AnimTexts.SetBool("isShaking", false);
        StartCoroutine("waitForAudio");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPos.transform.position, speed * Time.deltaTime);
        
        if (theCamera.transform.position == endPos.transform.position)
        {
            theCamera.transform.position = startPos.transform.position;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (speed >= 0.5f)
            {
                speed = 0;
            }
            else
            {
                speed = 1.5f;
            }
        }

        
    }

    IEnumerator waitForAudio()
    {
        yield return new WaitForSeconds(2f);
        AnimGameObjects.SetBool("isShaking", true);
        AnimTexts.SetBool("isShaking", true);
        yield return new WaitForSeconds(8f);
        AnimGameObjects.SetBool("isShaking", false);
        AnimTexts.SetBool("isShaking", false);
    }
}
