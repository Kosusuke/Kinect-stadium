using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

public class ranking : MonoBehaviour {

    Text myText;
    public int type;
    public int juni;
	// Use this for initialization
	void Start () {
        myText = GetComponentInChildren<Text>();//UIのテキストの取得の仕方
    }
	
	// Update is called once per frame
	void Update () {
        if (Moji.x)
        {
            if (type == 0)
            {
                myText.text = (juni+1) + "  " + Moji.snamerank[juni];
            }
            else if (type == 1)
            {
                myText.text = Moji.scorerank[juni] + "";
            }
            else if (type == 2)
            {
                myText.text = (juni+1) + "  " + Moji.mnamerank[juni];
            }
            else if (type == 3)
            {
                myText.text = Moji.metrank[juni] + "";
            }
            
        }
        else
        {
            myText.text = " ";
        }
    }
}
