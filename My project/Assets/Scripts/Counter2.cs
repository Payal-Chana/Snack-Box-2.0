using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Counter2 : MonoBehaviour
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
        yield return new WaitForSeconds(2);
        StarPanel.SetActive(true);
        

    }

}
