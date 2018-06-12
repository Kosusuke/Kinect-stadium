using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lhandpos : MonoBehaviour
{

    public static Vector3 lhandvec;
    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        lhandvec = transform.position - player.transform.position;
    }
}
