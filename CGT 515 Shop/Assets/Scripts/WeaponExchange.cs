using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponExchange : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject weapon_1;//weapons
    public GameObject weapon_2;
    public GameObject weapon_3;
    public GameObject weapon_4;
    public GameObject weapon_5;
    public GameObject weapon_6;
    public GameObject weapon_7;
    public GameObject weapon_8;
    public GameObject weapon_9;
    public GameObject weapon_10;
    public GameObject weapon_11;
    public GameObject weapon_12;
    public GameObject weapon_13;
    public GameObject weapon_14;
    public GameObject weapon_15;
   
    //UItext choice = new UItext();

    void Update()
    {
        acquireWeapon(UItext.weapon);
    }

    public void acquireWeapon(int number)
    {
        if (number == 1)
        {
            weapon_1.SetActive(false);
        }
        if (number == 2)
        {
            weapon_2.SetActive(false);
        }
        if (number == 3)
        {
            weapon_3.SetActive(false);
        }
        if (number == 4)
        {
            weapon_4.SetActive(false);
        }
        if (number == 5)
        {
            weapon_5.SetActive(false);
        }
        if (number == 6)
        {
            weapon_6.SetActive(false);
        }
        if (number == 7)
        {
            weapon_7.SetActive(false);
        }
        if (number == 8)
        {
            weapon_8.SetActive(false);
        }
        if (number == 9)
        {
            weapon_9.SetActive(false);
        }
        if (number == 10)
        {
            weapon_10.SetActive(false);
        }
        if (number == 11)
        {
            weapon_11.SetActive(false);
        }
        if (number == 12)
        {
            weapon_12.SetActive(false);
        }
        if (number == 13)
        {
            weapon_13.SetActive(false);
        }
        if (number == 14)//the key
        {
            weapon_14.SetActive(false);
        }
        if (number == 15)//the key
        {
            weapon_15.SetActive(false);
        }



    }



}
