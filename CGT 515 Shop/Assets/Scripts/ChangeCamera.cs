using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera: MonoBehaviour
{
    
    public GameObject weapon;
    public GameObject mainCamera;
    public GameObject sideCamera;
    public GameObject canvas;
    public Light one;
    public Light two;

    void Start()
    {
        one = one.GetComponent<Light>();
        two=two.GetComponent<Light>();
        one.enabled = false;
        two.enabled = false;
    }

    private void OnMouseDown()
    {
        mainCamera.SetActive(false);
        sideCamera.SetActive(true);
        weapon.SetActive(true);
        canvas.SetActive(true);
        one.enabled = true;
        two.enabled = true;
      
    }


    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            mainCamera.SetActive(true);
            sideCamera.SetActive(false);
            weapon.SetActive(false);
            canvas.SetActive(false);
            one.enabled = false;
            two.enabled = false;
        }
    }
   

}
