using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

public class focus : MonoBehaviour {

    Image image;
    public static int foc;

    // Use this for initialization
    void Start()
    {
        image = GetComponent<Image>();
        image.enabled = false;
        foc = 0;
    }

    // Update is called once per frame
    void Update()
    {
        image.enabled = false;
        if (foc == 1)
        {
            image.enabled = true;
        }
    }
}
