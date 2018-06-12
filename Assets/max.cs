using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

public class max : MonoBehaviour {

    public static float maxmeter;
    Text myText;

    // Use this for initialization
    void Start () {
        myText = GetComponentInChildren<Text>();//UIのテキストの取得の仕方
        maxmeter = 0f;
	}
	
	// Update is called once per frame
	void Update () {

        if (ShotShell.playball)
        {
            if (maxmeter < 0.1)
            {
                myText.text = "ーー";
            }
            else
            {
                myText.text = maxmeter + "m";
            }
        }
        else
        {
            myText.text = "";
        }
	}
}
