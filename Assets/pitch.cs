using UnityEngine;
using System.Collections;

public class pitch : MonoBehaviour
{

    Animator animator;
    public static int pit;
    public Vector3 set;

    // ゲーム初期化処理
    void Start()
    {
        pit =0;
        animator = GetComponent(typeof(Animator)) as Animator;
    }

    // frameごとに呼び出される
    void Update()
    {

        if (pit==1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            this.transform.position = set;
            pit = 0;
            Invoke("changeanime", 2.5f);
        }

    }
    void changeanime()
    {
        animator.Play("ArmatureAction");
    }
}
