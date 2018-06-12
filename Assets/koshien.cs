using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koshien : MonoBehaviour {

    public AudioClip boundSound;
    public AudioClip homerun;




    GameObject shell;
    Collision c;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        //地面にボールが衝突、1バウンド目なら消す
        if (other.gameObject.name == "Shell(Clone)" && hitzone.hitflag == 0)
        {
            shell = GameObject.Find("Shell(Clone)");
            hitzone.hitflag = 1;
            //impact後なら hitフラグ
            if (impact.impactflag == 1)
            {
                //高さ０．５以上でHOMERUN
                //if (shell.transform.position.y > 0.5)
                
                    AudioSource.PlayClipAtPoint(homerun, shell.transform.position);
                    TextChange.textmode = 4;
                    hon.numhomerun += 1;
                    if (TextChange.flymeter > max.maxmeter)
                    {
                        max.maxmeter = TextChange.flymeter;
                    }
                
            }
            c = other;
            Invoke("destroyball", 2f);
        }
        AudioSource.PlayClipAtPoint(boundSound, shell.transform.position);
    }

    void destroyball()
    {
        impact.power = 0;
        impact.impactflag = 0;
        ShotShell.bflag = 0;
        TextChange.textmode = 0;
        Destroy(c.gameObject);
        hitzone.hitflag = 0;
        aura.auramode = 0;
    }

}