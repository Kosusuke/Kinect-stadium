using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhandpos : MonoBehaviour {

    public static Vector3 rhandvec;
    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
        rhandvec = transform.position - player.transform.position;

    }
}
