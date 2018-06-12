using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu5 : MonoBehaviour {

    int rflag;
    int lflag;
    // Use this for initialization
    void Start()
    {
        rflag = 0;
        lflag = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (lflag == 1 && rflag == 1)
        {
            menu1.pull = 1;
            ShotShell.piccher = 7;
            menu1.goal = 320f;
        }
        rflag = 0;
        lflag = 0;

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Rhand")
        {
            rflag = 1;
        }
        if (other.gameObject.name == "Lhand")
        {
            lflag = 1;
        }

    }

}