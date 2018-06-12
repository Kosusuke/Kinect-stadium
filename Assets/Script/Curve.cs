using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curve : MonoBehaviour {

    GameObject shell;
    Rigidbody rb;
     Vector3 zone1;
     Vector3 zone2;

    


    //変化球用ベクトル
    Vector3 straight;
    Vector3 slider1;
    Vector3 slider2;
    Vector3 shoot1;
    Vector3 shoot2;
    Vector3 Hslider1;
    Vector3 Hslider2;
    Vector3 Hshoot1;
    Vector3 Hshoot2;
    Vector3 fast1;
    Vector3 fast2;
    Vector3 cu1;
    Vector3 cu2;
    Vector3 slow1;
    Vector3 slow2;
    Vector3 curve1;
    Vector3 curve2;


    // Use this for initialization
    void Start () {
        

        straight = new Vector3(0,0,0);
        
        slider1 = new Vector3(0, 0, 0);
        slider2 = new Vector3(5, -3, 0);
        shoot1 = new Vector3(0, 0, 0);
        shoot2 = new Vector3(-3, -3, 0);

        Hslider1 = new Vector3(-5, 9, -5);
        Hslider2 = new Vector3(35, 9, 0);
        Hshoot1 = new Vector3(5, 9, -10);
        Hshoot2 = new Vector3(-25, 0, -10);
        curve1 = new Vector3(-5, 0, 8);
        curve2 = new Vector3(16, 5, 0);
        cu1 = new Vector3(0, 9, -100);
        cu2 = new Vector3(0, 5, 160);
        fast1 = new Vector3(0, -10, -300);
        fast2 = new Vector3(0, 0, -300);
        slow1 = new Vector3(0, -5, 6);
        slow2 = new Vector3(0, 0, 0);


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        shell = GameObject.Find("Shell(Clone)");


        //8でHスライダー
        if (ShotShell.var == 8)
        {
            zone1 = Hslider1;
            zone2 = Hslider2;
        }
        //7でシュート
        else if (ShotShell.var == 7)
        {
            zone1 = Hshoot1;
            zone2 = Hshoot2;
        }
        //6でチェンジアップ
        else if (ShotShell.var == 6)
        {
            zone1 = cu1;
            zone2 = cu2;
        }
        //4でスロー
        else if (ShotShell.var == 4)
        {
            zone1 = zone2 = straight;
            //zone1 = slow1;
            //zone2 = slow2;
        }
        //5でカーブ
        else if (ShotShell.var == 5)
        {
            zone1 = curve1;
            zone2 = curve2;
        }
        //9で速球
        else if (ShotShell.var == 9)
        {
            zone1 = fast1;
            zone2 = fast2;
        }
        else
        {
            zone1 = zone2 = straight;
        }





        if (ShotShell.playball && shell!=null)
        {
            //バッター寄り
            if (shell.transform.position.z > 9 && shell.transform.position.z < 18 && impact.impactflag == 0)
            {
                Rigidbody rb = shell.GetComponent<Rigidbody>();
                rb.AddForce(zone1, ForceMode.Acceleration);
            }
            //バッター寄り
            else if (shell.transform.position.z > 3 && shell.transform.position.z < 9 && impact.impactflag == 0)
            {
                Rigidbody rb = shell.GetComponent<Rigidbody>();
                rb.AddForce(zone2, ForceMode.Acceleration);
            }
            else
            {

            }
        }
    }
}
