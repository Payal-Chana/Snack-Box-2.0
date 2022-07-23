using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public static bool gameisPaused;
    public GameObject pauseMenu;

    public void Start()
    {
        Time.timeScale = 1f;

    }

    public void Update()
    {
        if (gameisPaused)
        {
            Time.timeScale = 0f;
            AudioListener.volume = 0f;
            //gameisPaused = false;
        }
        else
        {
            Time.timeScale = 1f;
            AudioListener.volume = 1f;
            //gameisPaused = true;
        }
    }

    public void ButtonPause()
    {
        gameisPaused = true;
        pauseMenu.SetActive(true);

        //Sound for object placed down
        FindObjectOfType<MusicManager>().Play("button");
    }

    public void ButtonResume()
    {
        gameisPaused = false;
        pauseMenu.SetActive(true);
        
        //Sound for object placed down
        FindObjectOfType<MusicManager>().Play("button");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameisPaused = false;
        
        //Sound for object placed down
        FindObjectOfType<MusicManager>().Play("button");
    }
    
    public void Home()
    {
        SceneManager.LoadScene("CassettePlayer");
        gameisPaused = false;
        
        //Sound for object placed down
        FindObjectOfType<MusicManager>().Play("button");
    }

    public void Exit()
    {
        Application.Quit();
        gameisPaused = false;
        
        //Sound for object placed down
        FindObjectOfType<MusicManager>().Play("button");
    }


    public void AfterLevelSelect()
    {
        gameisPaused = false;

    }
}
