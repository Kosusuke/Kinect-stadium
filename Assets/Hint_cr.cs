using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

public class Hint_cr : MonoBehaviour
{

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
        if (ShotShell.hint == 1)
        {
            if (ShotShell.var == 9)
            {
                image.enabled = true;
            }
        }
    }
}
