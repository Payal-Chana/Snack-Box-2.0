using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceControlsAnim : MonoBehaviour
{
    public Animator anim;

    private void Start()
    {
        //anim.SetBool("isMouseAnimPlaying", false);
        StartCoroutine("waitForSecondsMate");
    }

    IEnumerator waitForSecondsMate()
    {
        yield return new WaitForSeconds(8f);
        anim.SetBool("isSpaceAnimPlaying", true);
        yield return new WaitForSeconds(10f);
        anim.SetBool("isSpaceAnimPlaying", false);
    }
}
