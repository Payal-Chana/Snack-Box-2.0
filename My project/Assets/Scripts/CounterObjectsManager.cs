using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterObjectsManager : MonoBehaviour
{
    public int FoundCounter = 0;
    public int finalNumberOfObjectsFound;
    public GameObject StarPanel;

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
        yield return new WaitForSeconds(2);
        //SceneManager.LoadScene("Credits");
    }
}
