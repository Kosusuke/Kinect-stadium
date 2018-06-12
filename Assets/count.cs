using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要
public class count : MonoBehaviour {

    Text myText;
    public static int flag;
    int mode;
    public static int pflag;
    // Use this for initialization
    void Start () {
        myText = GetComponentInChildren<Text>();//UIのテキストの取得の仕方
        flag = 0;
        pflag = 0;
        mode = 0;
    }
	
	// Update is called once per frame
	void Update () {

        if (ShotShell.bflag==1 && flag == 0)
        {
            flag = 1; 
            Invoke("count3", 1.5f);
        }

        if (mode == 3)
        {
            myText.text = "3";
        }
        else if (mode == 2){
            myText.text = "2";
        }
        else if (mode == 1)
        {
            myText.text = "1";
        }
        else
        {
            myText.text = " ";
        }


	}

    void count3()
    {
        pflag = 1;
        mode = 3;
        Invoke("count2",1f);
    }
    void count2()
    {
        mode = 2;
        Invoke("count1", 1f);
    }
    void count1()
    {
        mode = 1;
        Invoke("count0", 1f);
    }
    void count0()
    {
        mode = 0;
        pflag = 0;
    }

}
