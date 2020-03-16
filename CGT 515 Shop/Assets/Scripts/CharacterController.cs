using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject SideCamera2;
    // Start is called before the first frame update
    void Start()
    {
        
            Cursor.lockState = CursorLockMode.Locked;  //turn off cursor so don't see it on screen; locks it inside game, cursor is in the middle
        
       
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical")*speed;
        float straffe = Input.GetAxis("Horizontal") * speed;//Unity controls this values internally

        translation *= Time.deltaTime;//move smoothly at the same rate
        straffe *= Time.deltaTime;//side movements

        transform.Translate(straffe, 0, translation);//straffe along x axis and trabnslate along z axis

       /*if (Input.GetKeyDown(KeyCode.O))
        {
            Cursor.lockState = CursorLockMode.None;//turn this function off
        }*/

        if (Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif

        }
    }


}

