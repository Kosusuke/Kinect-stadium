using UnityEngine;
using System.Collections;

public class UnityChanDemo1 : MonoBehaviour
{



    // Update is called once per frame
    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 v = this.transform.position;
        v.x += x * 1f;
        v.z += y * 1f;
        this.transform.position = v;
    }
}
