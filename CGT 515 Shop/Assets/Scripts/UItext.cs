using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UItext : MonoBehaviour
{
    public static float currentPrice;//this should be public
    public Text priceText;//price of weapon
    public Text amount;//amount of money player has
    
    

    public static float money=300.0f;
    //public static float purchase;//nedds to be static

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
    public GameObject weapon_14;//scythe
    public GameObject weapon_15;//scythe

    public static int weapon = 0;//need this to know which weapon to delete in store

    private void Start()
    {
        // purchase = 300.0f;
        money = 300.0f;
        amount.text = "$" + money.ToString();//text of amount of money player has
    }


    void Update() {
       

        if (weapon_11.activeInHierarchy==true)//silver sword
        {
            currentPrice = 30.0f;
            priceText.text = "SILVER SWORD:" + " " + currentPrice.ToString();

            if (Input.GetKeyDown(KeyCode.Y))//buy weapon
            {
                money = money - currentPrice;//decrease money
                amount.text = "$" + money.ToString();
                
                priceText.text = "Acquired";
                weapon_11.SetActive(false);
                weapon = 11;//delete weapon in store
                //purchase = money;
            }
        }
        else if (weapon_1.activeInHierarchy == true)//metal shiled
        {
            currentPrice = 100.0f;
            priceText.text = "METAL SHIELD:" + " " + currentPrice.ToString();

            if (Input.GetKeyDown(KeyCode.Y))//but weapon
            {
                money = money - currentPrice;//decrease money
                amount.text = "$" + money.ToString();

                priceText.text = "Acquired";
                weapon_1.SetActive(false);
                weapon = 1;//delete weapon in store
                //purchase = money;
            }
        }
        else if (weapon_2.activeInHierarchy == true)//wood shiled
        {
            currentPrice = 70.0f;
            priceText.text = "WOOD SHIELD:" + "$" + currentPrice.ToString();

            if (Input.GetKeyDown(KeyCode.Y))//buy weapon
            {
                money = money - currentPrice;//decrease money
                amount.text = "$" + money.ToString();
                
                priceText.text = "Acquired";
                weapon_2.SetActive(false);
                weapon = 2;//delete weapon in store
                //purchase = money;
            }
        }
        else if (weapon_3.activeInHierarchy == true)//spear
        {
            currentPrice = 50.0f;
            priceText.text = "SPEAR:" + "$" + currentPrice.ToString();

            if (Input.GetKeyDown(KeyCode.Y))//buy weapon
            {
                money = money - currentPrice;//decrease money
                amount.text = "$" + money.ToString();
                
                priceText.text = "Acquired";
                weapon_3.SetActive(false);
                weapon = 3;//delete weapon in store
                //purchase = money;
            }
        }
        else if (weapon_4.activeInHierarchy == true)//halberd
        {
            currentPrice = 70.0f;
            priceText.text = "HALBERD:" + "$" + currentPrice.ToString();

            if (Input.GetKeyDown(KeyCode.Y))//buy weapon
            {
                money = money - currentPrice;//decrease money
                amount.text = "$" + money.ToString();
                
                priceText.text = "Acquired";
                weapon_4.SetActive(false);
                weapon = 4;//delete weapon in store
                //purchase = money;
            }
        }
        else if (weapon_5.activeInHierarchy == true)//two-handed sword
        {
            currentPrice = 150.0f;
            priceText.text = "TWO-HANDED SWORD:" + "$" + currentPrice.ToString();

            if (Input.GetKeyDown(KeyCode.Y))//buy weapon
            {
                money = money - currentPrice;//decrease money
                amount.text = "$" + money.ToString();
                
                priceText.text = "Acquired";
                weapon_5.SetActive(false);
                weapon = 5;//delete weapon in store

                //purchase = money;
            }
        }
        else if (weapon_6.activeInHierarchy == true)//battle axe
        {
            currentPrice = 60.0f;
            priceText.text = "BATTLE AXE:" + "$" + currentPrice.ToString();

            if (Input.GetKeyDown(KeyCode.Y))//buy
            {
                money = money - currentPrice;//decrease money
                amount.text = "$" + money.ToString();
                
                priceText.text = "Acquired";
                weapon_6.SetActive(false);
                weapon = 6;//delete weapon in store
                //purchase = money;
            }
        }
        else if (weapon_7.activeInHierarchy == true)//hand axe
        {
            currentPrice = 30.0f;
            priceText.text = "HAND AXE:" + "$" + currentPrice.ToString();

            if (Input.GetKeyDown(KeyCode.Y))//buy
            {
                money = money - currentPrice;//decrease money
                amount.text = "$" + money.ToString();
                
                priceText.text = "Acquired";
                weapon_7.SetActive(false);
                weapon = 7;//delete weapon in store
                //purchase = money;
            }
        }
        else if (weapon_8.activeInHierarchy == true)//rapier
        {
            currentPrice = 100.0f;
            priceText.text = "RAPIER:" + "$" + currentPrice.ToString();

            if (Input.GetKeyDown(KeyCode.Y))//buy
            {
                money = money - currentPrice;//decrease money
                amount.text = "$" + money.ToString();
                
                priceText.text = "Acquired";
                weapon_8.SetActive(false);
                weapon = 8;//delete weapon in store
                //purchase = money;
            }
        }
        else if (weapon_9.activeInHierarchy == true)//heavy mace
        {
            currentPrice = 150.0f;
            priceText.text = "HEAVY MACE:" + "$" + currentPrice.ToString();

            if (Input.GetKeyDown(KeyCode.Y))//buy
            {
                money = money - currentPrice;//decrease money
                amount.text = "$" + money.ToString();
                
                priceText.text = "Acquired";
                weapon_9.SetActive(false);
                weapon = 9;//delete weapon in store
                //purchase = money;
            }
        }
        else if (weapon_10.activeInHierarchy == true)//morning star
        {
            currentPrice = 200.0f;
            priceText.text = "MORNING STAR:" + "$" + currentPrice.ToString();

            if (Input.GetKeyDown(KeyCode.Y))//buy
            {
                money = money - currentPrice;//decrease money
                amount.text = "$" + money.ToString();
                
                priceText.text = "Acquired";
                weapon_10.SetActive(false);
                weapon = 10;//delete weapon in store
                //purchase = money;
            }
        }
        else if (weapon_12.activeInHierarchy == true)//dagger
        {
            currentPrice = 20.0f;
            priceText.text = "DAGGER:" + "$" + currentPrice.ToString();

            if (Input.GetKeyDown(KeyCode.Y))//buy
            {
                money = money - currentPrice;//decrease money
                amount.text = "$" + money.ToString();
                
                priceText.text = "Acquired";
                weapon_12.SetActive(false);
                weapon = 12;//delete weapon in store
                //purchase = money;
            }
        }
        else if (weapon_13.activeInHierarchy == true)//longsword
        {
            currentPrice = 250.0f;
            priceText.text = "LONGSWORD:" + " " + currentPrice.ToString();

            if (Input.GetKeyDown(KeyCode.Y))//buy
            {
                money = money - currentPrice;//decrease money
                amount.text = "$" + money.ToString();
               
                priceText.text = "Acquired";
                weapon_13.SetActive(false);
                weapon = 13;//delete weapon in store


                //purchase = money;
            }
        }
      else if (weapon_14.activeInHierarchy == true)//scythe
            {
                currentPrice = 150.0f;
                priceText.text = "Scythe:" + " " + currentPrice.ToString();

                if (Input.GetKeyDown(KeyCode.Y))//buy
                {
                    money = money - currentPrice;//decrease money
                    amount.text = "$" + money.ToString();

                    priceText.text = "Acquired";
                    weapon_14.SetActive(false);
                    weapon = 14;//delete weapon in store


                    //purchase = money;
                }
            }
        else if (weapon_15.activeInHierarchy == true)//scythe
        {
            currentPrice = 150.0f;
            priceText.text = "Scythe:" + " " + currentPrice.ToString();

            if (Input.GetKeyDown(KeyCode.Y))//buy
            {
                money = money - currentPrice;//decrease money
                amount.text = "$" + money.ToString();

                priceText.text = "Acquired";
                weapon_15.SetActive(false);
                weapon = 15;//delete weapon in store


                //purchase = money;
            }
        }



    }

    

}
