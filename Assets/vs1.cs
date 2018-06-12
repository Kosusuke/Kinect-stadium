using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

public class vs1 : MonoBehaviour {

    Image image;
    public int vs;

	// Use this for initialization
	void Start () {
        image = GetComponent<Image>();
        image.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (ShotShell.piccher == vs && ShotShell.playball)
        {
            image.enabled = true;
        }
        else
        {
            image.enabled = false;
        }

	}
}
