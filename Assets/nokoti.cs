using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

public class nokoti : MonoBehaviour {

    Text myText;

    // Use this for initialization
    void Start()
    {
        myText = GetComponentInChildren<Text>();//UIのテキストの取得の仕方
    }

    // Update is called once per frame
    void Update()
    {
        if (ShotShell.playball)
        {
            myText.text = (ShotShell.nokori+1)  + "";
        }
        else
        {
            myText.text = "";
        }
    }
}
