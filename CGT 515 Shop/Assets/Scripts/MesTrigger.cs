using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesTrigger : MonoBehaviour
{
    public GameObject panel;
    private void OnTriggerEnter(Collider other)//show message
    {
        panel.SetActive(true);
        
    }

    private void OnTriggerExit(Collider other)//stop showing message
    {
        panel.SetActive(false);

    }

}
