using UnityEngine;
using System.Collections;



public class FollowBall : MonoBehaviour
{

    GameObject shell;
    GameObject mainCamera;
    int flag;

    public float x;
    public float y;
    public float z;

    // Use this for initialization
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");    
    }
    // Update is called once per frame
    void Update()
    {
        shell = GameObject.Find("Shell(Clone)");
            //追従モード
        if (impact.impactflag == 1)
        {
            if (hitzone.hitflag == 0)
            {
                TextChange.flymeter = Mathf.Ceil(Mathf.Sqrt((shell.transform.position.x) * (shell.transform.position.x) + (shell.transform.position.z) * (shell.transform.position.z)));
            }
            Invoke("withball", 0.3f);
            if(flag == 1)
            {

                mainCamera.transform.position = new Vector3(shell.transform.position.x, shell.transform.position.y + 1, shell.transform.position.z - 5);
            }
        }
        //初期位置に戻る
        else
        {
            mainCamera.transform.position = new Vector3(x,y,z);
            flag = 0;
        }
    }

    void withball()
    {
        flag = 1;
        //集中線
        focus.foc = 0;
    }
}