using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meet : MonoBehaviour {

    GameObject shell;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        shell = GameObject.Find("Shell(Clone)");
        if (shell == null)
        {
            this.transform.position = new Vector3(0f, 0f, -10f);
        }
        else if (impact.impactflag == 0)
        {
            this.transform.position = new Vector3(shell.transform.position.x, 0.8f, -0.25f);
        }
        else
        {
            this.transform.position = new Vector3(0f, 0f, -10f);
        }
    }
}
