using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReferenceScene : MonoBehaviour
{
    public void ReferenceSceneBtn()
    {
        SceneManager.LoadScene("References");
        
        //Sound for object placed down
        FindObjectOfType<MusicManager>().Play("button");
    }
}
