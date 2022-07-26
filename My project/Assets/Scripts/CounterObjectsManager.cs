using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CounterObjectsManager : MonoBehaviour
{
    public int FoundCounter = 0;
    public int finalNumberOfObjectsFound;
    public GameObject StarPanel;
    Scene currentscene;

    
    private void Update()
    {
        if (FoundCounter >= finalNumberOfObjectsFound)
        {
            StartCoroutine("starPanel");
            
        }
    }
    
    IEnumerator starPanel()
    {
        yield return new WaitForSeconds(5);
        StarPanel.SetActive(true);
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene("Credits");
        
    }

    IEnumerator starPanel2()
    {
        yield return new WaitForSeconds(5);
        StarPanel.SetActive(true);
        yield return new WaitForSeconds(8);
        //SceneManager.LoadScene("Credits");

    }
}
