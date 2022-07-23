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
    
    public void Exit()
    {
        Application.Quit();
        
        
        //Sound for object placed down
        FindObjectOfType<MusicManager>().Play("button");
    }
    
    public void Home()
    {
        SceneManager.LoadScene("CassettePlayer");
        
        
        //Sound for object placed down
        FindObjectOfType<MusicManager>().Play("button");
    }
}
