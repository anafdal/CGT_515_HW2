using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Money : MonoBehaviour 
{
    public static float amount;
    public Text amountText;
    public Text other;
    public Text gameOver;
    public GameObject death;//the seller
    public Image cursor;
    public GameObject deathPos;
    public GameObject canvas;
    public GameObject swords;
    public GameObject sword;
    public Light redLight;
    

    private void Start()
    {
        amount = 300.0f;//initial amount
        

        amountText.text = "$"+ amount.ToString();
        redLight = redLight.GetComponent<Light>();
        redLight.enabled = false;
    }

    void Update()
    {
        amountText.text = other.text;
        amount = UItext.money;//get current money
   

        if (amount <= 0)
        {
            gameOver.gameObject.SetActive(true);
            death.transform.position =new Vector3 (deathPos.transform.position.x,50.0f ,deathPos.transform.position.z);
            death.transform.rotation = Quaternion.Euler(0, 90, 0);

            sword.SetActive(false);
            swords.SetActive(false);
            redLight.enabled=true;
            death.GetComponent<Animator>().SetBool("Scream", true);
            //Start the coroutine we define below named ExampleCoroutine.
            StartCoroutine(ExampleCoroutine());//wait 5 seconds
        }

    
    }

   
    IEnumerator ExampleCoroutine()//game lost
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
