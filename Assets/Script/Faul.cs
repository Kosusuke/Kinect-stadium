using UnityEngine;
using System.Collections;


public class Faul : MonoBehaviour {


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

         // hitzone.hitflag = 1;
            c = other;
         // Invoke("destroyball", 1f);
            TextChange.textmode = 2;
        
    }

    void destroyball()
    {
        TextChange.textmode = 0;
        impact.impactflag = 0;
        ShotShell.bflag = 0;
        Destroy(c.gameObject);
        hitzone.hitflag = 0;
    }
}
