using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condition : MonoBehaviour
{
    public bool ifbool;
    public int value;


    // Use this for initialization
    void Start()
    {
        if (ifbool == true)
        {
            print("ja");
        }
        else
        {
            print("nej");
        }


    }



    // Update is called once per frame
    void Update()
    {
        // != inte lika med
        // == lika med
        // > större än
        // < mindre än
        // >= större eller lika med
        // <= mintre eller lika med
        // && och (shift 6)
        // || eller (alt gr <)
        if (Input.GetKeyDown(KeyCode.E))
        {
            value = Random.Range(0, 10);
            print("Du E");
        }

        if (value == 5)
        {
            if (ifbool == true)
            {
                print("hej");
            }
        }
        else if (value == 4)
        {
            print("hur mår du");
        }
        else if (value == 3)
        {
            print("vill du bli");
        }
        else if (value == 2)
        {
            print("min vän");
        }
        else if (value == 1)
        {
            print("Hejdå");
        }
        else if (value == 0)
        {
            print("vad vill du!!!!");
        }
    }
}
