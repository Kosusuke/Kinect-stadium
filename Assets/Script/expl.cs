using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expl : MonoBehaviour {

    public GameObject ExploadObj;
    //public GameObject ExploadPos;
    GameObject ball;
    int flag=0; 
    // Update is called once per frame
    void Update()
    {
        
        //スペースキーを押したら
        if (hitzone.hitflag==1 && flag==0)
        {
            ball = GameObject.Find("Shell(Clone)");
            Instantiate(ExploadObj, ball.transform.position, Quaternion.identity);
            flag = 1;
        }
        if (hitzone.hitflag == 0)
        {
            flag = 0;
        }
    }
}