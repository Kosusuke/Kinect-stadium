using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

public class power : MonoBehaviour {

    public AudioClip drum;
    public GameObject cam;
    Text myText;
    public int type;
    bool flag;
    // Use this for initialization
    void Start () {
        myText = GetComponentInChildren<Text>();//UIのテキストの取得の仕方
        flag = true;
    }
	
	// Update is called once per frame
	void Update () {

        

        if (Scoreboard.resultview)
        {
            if (type == 1 && flag)
            {
                Invoke("tex1", 1f);
                flag = false;
            }
            else if (type == 2 && flag)
            {
                Invoke("tex2", 3f);
                Invoke("tex22", 3.5f);
                flag = false;
            }
            else if (type == 3 && flag)
            {
                Invoke("tex3", 4.5f);
                Invoke("tex32", 5f);
                flag = false;
            }
            else if (type == 4 && flag)
            {
                Invoke("tex4", 6f);
                Invoke("end", 10f);
                flag = false;
            }
        }
        else
        {
            myText.text = " ";
        }
    }

    void tex1()
    {
        myText.text = "result";
        AudioSource.PlayClipAtPoint(drum, cam.transform.position);
    }
    void tex2()
    {
        myText.text = "homerun";
        AudioSource.PlayClipAtPoint(drum, cam.transform.position);
    }
    void tex22()
    {
        myText.text = "homerun : "+hon.numhomerun;
        AudioSource.PlayClipAtPoint(drum, cam.transform.position);
    }
    void tex3()
    {
        myText.text = "max";
        AudioSource.PlayClipAtPoint(drum, cam.transform.position);
    }
    void tex32()
    {
        myText.text = "max : "+max.maxmeter+"m";
        AudioSource.PlayClipAtPoint(drum, cam.transform.position);
    }
    void tex4()
    {
        myText.text = "thank you";
        AudioSource.PlayClipAtPoint(drum, cam.transform.position);
        var filename = System.DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".png";
        Application.CaptureScreenshot(filename);
    }
    void end()
    {
        Application.Quit();
    }
}
