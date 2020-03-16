using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Text talk;
    public string[] sentences;//sentences
    public string[] conversation1;
    public string[] conversation2;
    
    private int index;
    private int index1;
    private int index2;

    public float typingSpeed;
    private bool stop = false;//to check when certain conversations end
    private bool con = true;
    private int conNum=0;

    private void Start()
    {
        StartCoroutine(Type0());
      
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))//got to next sentence
        {
            NextSentence();
        }

        if (stop == true)//if one conversations has ended
        {
            talk.fontSize = 10;
          
            talk.text = "(A to ask about the weapons or B to ask about Death.)";
            index1 = 0;//start over each conversation
            index2 = 0;
            stop = false;
        }

        if (Input.GetKeyDown(KeyCode.A))//start conversation 1
        {
            conNum = 1;
            talk.text = "";
            talk.fontSize = 10;
            StartCoroutine(Type1());
        }
        if (Input.GetKeyDown(KeyCode.B))//start conversation 2
        {
            conNum = 2;
            talk.text = "";
            talk.fontSize = 10;
            StartCoroutine(Type2());
        }
    }

    IEnumerator Type0()//start conversation
        {
            foreach (char letter in sentences[index].ToCharArray())
            {
                talk.text += letter;
                yield return new WaitForSeconds(typingSpeed);//wait before showing up
                Debug.Log(index);
            }
        }

    IEnumerator Type1()//conversation 1 
    {
        
        foreach (char letter in conversation1[index1].ToCharArray())
        {
            talk.text += letter;
            yield return new WaitForSeconds(typingSpeed);//wait before showing up
        }
    }
    IEnumerator Type2()//conversation 2
    {

        foreach (char letter in conversation2[index2].ToCharArray())
        {
            talk.text += letter;
            yield return new WaitForSeconds(typingSpeed);//wait before showing up
        }
    }


    public void NextSentence()
    {
        if (index<sentences.Length-1)
        {
            index++;
            talk.text = "";//don't want old sentence to show
            StartCoroutine(Type0());
        }
        else if(index1 < conversation1.Length - 1 && index== sentences.Length - 1 && con==false && conNum==1)//previous start conversation has already ended
        {
            index1++;
            talk.text = "";//don't want old sentence to show
            StartCoroutine(Type1());
        }
        else if(index2 < conversation2.Length - 1 && index == sentences.Length - 1 && con == false && conNum==2)
        {
            index2++;
            talk.text = "";//don't want old sentence to show
            StartCoroutine(Type2());
        }
        else
        {
            talk.text = "";
            stop = true;
            con = false;//go to next conversations
           // Debug.Log("end1");

        }
    }
 
}
