using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pb : MonoBehaviour {

    GameObject menuCamera;
    GameObject parent;
    GameObject L;
    GameObject R;
    public GameObject bgm;
    public AudioClip Sound;
    int rflag;
    int lflag;
    int flag;
    // Use this for initialization
    void Start()
    {
        menuCamera = GameObject.Find("Menu Camera");
        parent = GameObject.Find("menu1");
        R = GameObject.Find("Rhand");
        L = GameObject.Find("Lhand");
        rflag = 0;
        lflag = 0;
        flag = 0;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (lflag == 1 && rflag == 1 && flag==0)
        {
            
            Invoke("palyball", 1f);
            flag = 1;
            

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

    void palyball()
    {
        menuCamera.SetActive(false);
        ShotShell.playball = true;
        parent.gameObject.SetActive(false);
        R.gameObject.SetActive(false);
        L.gameObject.SetActive(false);
        menu1.act = false;
        bgm.SetActive(true);
        AudioSource.PlayClipAtPoint(Sound, new Vector3(0f,0f,0f));
    }

}