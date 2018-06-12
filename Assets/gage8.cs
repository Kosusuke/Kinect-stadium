using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

public class gage8 : MonoBehaviour
{
    int flag = 0;
    Image image;
    public AudioClip Sound;
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
        if (impact.impactflag == 1 || hitzone.hitflag == 1)
        {
            image.enabled = false;
            flag = 0;
        }
        else if (impact.power >= 50f)
        {
            image.enabled = true;
            impact.impacts = new Vector3(0f, 2000f, 6000f);
            if (flag == 0)
            {
                aura.auramode = 8;
                AudioSource.PlayClipAtPoint(Sound, new Vector3(0, 0, 0));
                flag = 1;
            }
        }
        
    }
}
