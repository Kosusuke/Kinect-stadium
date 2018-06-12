using UnityEngine;
using System.Collections;
using UnityEngine.UI;//この宣言が必要

public class TextChange: MonoBehaviour { 



    Text myText;
    public static int textmode;
    public static float flymeter;
    public static float homemeter;

    // Use this for initialization
    void Start()
    {
        
        myText = GetComponentInChildren<Text>();//UIのテキストの取得の仕方
    }

    // Update is called once per frame
    void Update()
    {
        if ( textmode == 1)
        {
            myText.text = "STRIKE";
        }
        else if ( textmode == 2 )
        {
            myText.text = "FOUL";
        }
        else if( textmode == 3 )
        {
           // myText.text = flymeter + "M";
        }
        else if (textmode == 4)
        {
            myText.text =  "HOMERUN";
        }
        else
        {
            myText.text = " ";
        }
    }


}