using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surprise : MonoBehaviour
{
    public GameObject key;
    public GameObject panel;
    public GameObject otherPanel;

    // Update is called once per frame
    void Update()
    {

        if (key.activeInHierarchy == false)
        {
         
            panel.SetActive(true);
            StartCoroutine(ExampleCoroutine());//wait 5 seconds
            otherPanel.SetActive(false);
        }
    }


    IEnumerator ExampleCoroutine()//game won
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 2 seconds.
        yield return new WaitForSeconds(5);


        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
    }
}
