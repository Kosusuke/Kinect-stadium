using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aura : MonoBehaviour {

    public GameObject ExploadObj;
    public static int auramode = 0;
    public int num;
    // Update is called once per frame
    void Update()
    {

        if (auramode == num)
        {
            this.transform.position = new Vector3(-1f, -0.1f, -0.3f);
            //Instantiate(ExploadObj, this.transform.position, Quaternion.identity);
        }
        else
        {
            this.transform.position = new Vector3(0, 0, -200);
        }
    }
}