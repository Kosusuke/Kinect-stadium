using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu1 : MonoBehaviour {

    public Vector3 velocity;
    public static float goal;
    public float key;
    public static int pull;
    public static bool act;
    public AudioClip Sound;

    GameObject rh;
    GameObject lh;
    int flag;
    int moveflag;
    int rflag;
    int lflag;
    // Use this for initialization
    void Start () {
        moveflag = 0;
        pull = 0;
        rflag = 0;
        lflag = 0;
        act = true;
        flag = 0;
        rh = GameObject.Find("Rhand");
        lh = GameObject.Find("Lhand");
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        rh.SetActive(act);
        lh.SetActive(act);
        
        if(lflag==1 && rflag == 1 && flag==0)
        { 
            Invoke("move", 1.5f);
            goal = 160f;
            flag = 1;
            AudioSource.PlayClipAtPoint(Sound, new Vector3(0f, 0f, 0f));
        }
        rflag = 0;
        lflag = 0;

        if (goal > transform.position.x && moveflag == 1)
        {
            act = false;
            transform.position += velocity;
        }

        if(transform.position.x % 160f == 0 && act == false)
        {
            Invoke("handon", 1f);
        }

        if (pull == 1)
        {
            Invoke("move", 1.5f);
            pull = 0;
        }
        
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

    void move()
    {
        moveflag = 1;
    }

    void handon()
    {
        act = true;
        moveflag = 0;
    }
}
