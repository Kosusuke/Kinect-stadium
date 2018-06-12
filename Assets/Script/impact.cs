using UnityEngine;
using System.Collections;

public class impact : MonoBehaviour {


    GameObject shell;
    public static Vector3 impacts;
    Vector3 preVec;
    float swingspeed;
    public static int impactflag;
    public AudioClip impactSound;
    public static float power;
    float rad;
    // Use this for initialization
    void Start () {
        power = 0;
        preVec = transform.position;
        impactflag = 0;
    }
	
	// Update is called once per frame
	void Update () {

        swingspeed  = (preVec - transform.position).magnitude;
        preVec = transform.position;
        if (count.pflag == 1)
        {
            power += swingspeed;
        }
    }

    
    
     void OnCollisionEnter(Collision collision)
     {
        if (shell == null)
        {
            shell = GameObject.Find("Shell(Clone)");
            
        }

         if (collision.gameObject.name == "Shell(Clone)")
         {
            AudioSource.PlayClipAtPoint(impactSound, transform.position);
            impactflag = 1;
            focus.foc = 1;
            Rigidbody shellRigidbody = shell.GetComponent<Rigidbody>();
            if (swingspeed > 0.1f)
            {
                swingspeed = 0.6f;
            }
            rad = 5f*Random.value-10f;
            impacts = new Vector3(impacts.x + rad, impacts.y, impacts.z);
            shellRigidbody.AddForce(impacts*swingspeed, ForceMode.Acceleration);
            Debug.Log("速度: " + swingspeed);
        }

    }
     
}
