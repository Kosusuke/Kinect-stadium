using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

public class Scoreboard : MonoBehaviour {


    Image image;
    public static bool resultview;
    // Use this for initialization
    void Start()
    {
        resultview = false;
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        image.enabled = ShotShell.playball;
        if (resultview)
        {
            this.gameObject.SetActive(false);
        }
    }
}
