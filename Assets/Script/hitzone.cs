using UnityEngine;
using System.Collections;

public class hitzone : MonoBehaviour {

    public AudioClip boundSound;
    public AudioClip homerun;
    public static int hitflag;

    public static int meter;

    GameObject shell;
    Collision c;
    // Use this for initialization
    void Start()
    {
        hitflag = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        //地面にボールが衝突、1バウンド目なら消す
        if (other.gameObject.name == "Shell(Clone)" && hitflag==0)
        {
            shell = GameObject.Find("Shell(Clone)");
            hitflag = 1;
            //impact後なら hitフラグ
            if (impact.impactflag == 1)
            {
                //高さ０．５以上でHOMERUN
                if (shell.transform.position.y > 0.5)
                {
                    AudioSource.PlayClipAtPoint(homerun, shell.transform.position);
                    TextChange.textmode = 4;
                    hon.numhomerun += 1;
                    Moji.scores += TextChange.flymeter;
                    if (TextChange.flymeter > max.maxmeter)
                    {
                        max.maxmeter = TextChange.flymeter;
                    }
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
        hitflag = 0;
        aura.auramode = 0;
    }

}