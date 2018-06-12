using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu7 : MonoBehaviour {

    int rflag;
    int lflag;
    int flag;
    public AudioClip Sound;

    // Use this for initialization
    void Start()
    {
        rflag = 0;
        lflag = 0;
        flag = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (lflag == 1 && rflag == 1 && flag==0)
        {
            flag = 1;
            menu1.pull = 1;
            ShotShell.piccher = 10;
            //menu1.goal = 320f;
            AudioSource.PlayClipAtPoint(Sound, new Vector3(0f, 0f, 0f));
        }
        rflag = 0;
        lflag = 0;

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Rhand" )
        {
            rflag = 1;
        }
        if (other.gameObject.name == "Lhand")
        {
            lflag = 1;
        }

    }

}
