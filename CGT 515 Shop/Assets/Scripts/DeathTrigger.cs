using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public GameObject panel;
    public GameObject MainCamera;//perspective camera
    public GameObject SideCamera2;//death scene camera

    public GameObject character;

   // public Animator myAnimator;//doesn't work

   
    private void OnTriggerEnter(Collider other)//talk to seller
    {
        panel.SetActive(true);
        //Debug.Log("EnterDeath");
        MainCamera.SetActive(false);
        SideCamera2.SetActive(true);
        character.GetComponent<Animator>().SetBool("Normal", true);
    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))//don't talk to seller
        {
            panel.SetActive(false);
            MainCamera.SetActive(true);
            SideCamera2.SetActive(false);
            character.GetComponent<Animator>().SetBool("Normal", false);
            // myAnimator.SetBool("Normal", false);
        }
    }
}
