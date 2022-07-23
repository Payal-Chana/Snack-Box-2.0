using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControls : MonoBehaviour
{
    public Animator anim;

    private void Start()
    {
        //anim.SetBool("isMouseAnimPlaying", false);
        StartCoroutine("waitForSecondsMate");
    }

    private void Update()
    {
        
        
    }

    IEnumerator waitForSecondsMate()
    {
        yield return new WaitForSeconds(4f);
        anim.SetBool("isMouseAnimPlaying", true);
        yield return new WaitForSeconds(6f);
        anim.SetBool("isMouseAnimPlaying", false);
    }
}
