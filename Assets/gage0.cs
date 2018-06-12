using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

public class gage0 : MonoBehaviour {

    Image image;

    // Use this for initialization
    void Start()
    {
        image = GetComponent<Image>();
        image.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        image.enabled = false;
        if (impact.power <1f && count.pflag==1)
        {
                image.enabled = true;
                impact.impacts = new Vector3(0f, 1500f, 800f);
        }
    }
}