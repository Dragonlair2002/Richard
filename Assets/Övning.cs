using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Övning : MonoBehaviour
{
    public int userValue;
    public int Dicevalue;
    public int Dragon;
    public int DragonDubble;
    public int DragonAttack;
    public int DragonDamage;
    public int Player;
    public int PlayerDamage;
    public int PlayerDamageMin;
    public int PlayerDamageMax;


    //Debug.Log(string.Format("Uppgift 8: {0}",));




    // Use this for initialization
    void Start()
    {
        DragonDubble = Random.Range(1, 11);
        if (DragonDubble == 1)
        {
            Dragon = Random.Range(200, 251);
        }
        if (DragonDubble != 1)
        {
            Dragon = Random.Range(100, 151);
        }

        Player = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue += 2;
            print(userValue);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue /= 2;
            print(userValue);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Dicevalue = Dicevalue += (Random.Range(1, 7));
            Dicevalue = Dicevalue -= (Random.Range(1, 7));
            Debug.Log(Dicevalue);
            if (Dicevalue >= 20)
            {
                print("20, Du Vann!");
            }
            else if (Dicevalue <= 0)
            {
                print("0, Du Förlorade");
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DragonAttack = (Random.Range(1, 3));

            if (DragonAttack == 1)
            {
                DragonDamage = Random.Range(10, 21);
            }
            if (DragonAttack == 2)
            {
                DragonDamage = 0;
                print("Missade");
            }
            PlayerDamage = (Random.Range(5, 26));
            if (PlayerDamage == 5)
            {

            }

            Player -= DragonDamage;
            Dragon -= PlayerDamage;
            Debug.Log(string.Format("Dakens liv {0}", Dragon));
            Debug.Log(string.Format("Spelarens Liv {0}", Player));

            if (Dragon <= 0)
            {
                print("Du vann");
            }

            if (Player <= 0)
            {
                print("Du förlorade");
            }

        }

    }
}
