using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LhandTrack : MonoBehaviour {

    float x;
    float y;
    float z;

    Vector3 prev1;
    Vector3 prev2;
    Vector3 prev3;
    Vector3 now;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //this.gameObject.SetActive(menu1.act);

        x = Lhandpos.lhandvec.x * (-100);
        y = (Lhandpos.lhandvec.y - 0.4f) * 100 - 70;
        z = -100;

        now = new Vector3(x, y, z);
        transform.position = (now + prev1 + prev2 + prev3) * 0.25f;
        prev3 = prev2;
        prev2 = prev1;
        prev1 = transform.position;
    }
}
