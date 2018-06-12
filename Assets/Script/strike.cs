using UnityEngine;
using System.Collections;


public class strike : MonoBehaviour
{

    public AudioClip strikeSound;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        AudioSource.PlayClipAtPoint(strikeSound, transform.position);
        if (impact.impactflag == 0)
        {
            TextChange.textmode = 1;
        }
        else
        {
            TextChange.textmode = 2;
        }
    }


}
