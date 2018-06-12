using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class part : MonoBehaviour {

    GameObject shell;

    // Use this for initialization
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        shell = GameObject.Find("Shell(Clone)");
        //追従モード
        if (impact.impactflag == 1)
        {
            this.transform.position = new Vector3(shell.transform.position.x, shell.transform.position.y, shell.transform.position.z-1f);
        }

    }
}