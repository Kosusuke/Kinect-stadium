using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

public class text0 : MonoBehaviour {

    Text myText;


    // Use this for initialization
    void Start()
    {

        myText = GetComponentInChildren<Text>();//UIのテキストの取得の仕方
    }

    // Update is called once per frame
    void Update()
    {
        if (impact.impactflag == 1)
        {
            myText.text = TextChange.flymeter + "M";
            if (TextChange.textmode == 4)
            {
                myText.color = Color.red;
            }
            else
            {
                myText.color = Color.blue;
            }
        }
        else
        {
            myText.text = "";
        }
    }
        
}