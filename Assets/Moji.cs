using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

// ファイル読み込み
public class Moji : MonoBehaviour
{
    int i;
    public static int mrank;
    public static int srank;
    bool f = true;
    bool c = false;
    public  static bool x = false;
    float pre;
    public static float scores = 0;
    string a="K";
    string b;

    public static float[] scorerank;
    public static float[] metrank;
    public static string[] snamerank;
    public static string[] mnamerank;

    // Use this for initialization
    void Start()
    {
        PlayerPrefsX.GetFloatArray("Score", 0f, 5);
        PlayerPrefsX.GetFloatArray("Met", 0f, 5);
        PlayerPrefsX.GetStringArray("SName","Player", 5);
        PlayerPrefsX.GetStringArray("MName", "Player", 5);

    }

    void Update(){
        
        if (Scoreboard.resultview && f)
        {
            f = false;
            sco();
            meter();
            x = true;
        }
    }
    void sco()
    {
        var myScore = PlayerPrefsX.GetFloatArray("Score");
        var snames = PlayerPrefsX.GetStringArray("SName");
        
        c = false;
        for (i = 0; i < 5; i++)
        {
            if (myScore[i] <= max.maxmeter && !c)
            {
                myScore[i] = max.maxmeter;
                snames[i] = a;
                c = true;
                srank = i;
            }
            if (c)
            {
                myScore[i] = pre;
                snames[i] = b;
            }
            pre = myScore[i];
            b = snames[i];
        }

        for (i = 0; i < 5; i++)
        {
            scorerank[i] = myScore[i];
            snamerank[i] = snames[i];
        }
        
        
        PlayerPrefsX.SetFloatArray("Score", myScore);
        PlayerPrefsX.SetStringArray("SName", snames);

    }
    void meter()
    {
        var met = PlayerPrefsX.GetFloatArray("Met");
        var mnames = PlayerPrefsX.GetStringArray("MName");
        
        //scores *= ShotShell.piccher;
        c = false;
        for (i = 0; i < 5; i++)
        {
            if (met[i] <= scores && !c)
            {
                met[i] = scores;
                mnames[i] = a;
                c = true;
                mrank = i;
            }
            if (c)
            {
                met[i] = pre;
                mnames[i] = b;
            }
            pre = met[i];
            b = mnames[i];
        }
        for (i = 0; i < 5; i++)
        {
            metrank[i] = met[i];
            mnamerank[i] = mnames[i];
        }
        
        PlayerPrefsX.SetFloatArray("Met", met);
        PlayerPrefsX.SetStringArray("MName", mnames);

    }
}