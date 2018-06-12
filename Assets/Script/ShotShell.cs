using UnityEngine;
using System.Collections;

public class ShotShell : MonoBehaviour
{
    public static bool playball;
    public GameObject shellPrefab;
    public GameObject bgm;
    public float shotSpeed;
    public AudioClip shotSound;
    public static int bflag;
    public static int var;
    public static int piccher;
    public static int hint;
    public static int nokori;
    float rot;
    GameObject resultcamera;


    private void Start()
    {
        resultcamera = GameObject.Find("rescam");
        resultcamera.SetActive(false);
        playball = false;
        hint = 0;
        bflag = 0;
        nokori = 5;
    }


    void Update()
    {
        if( bflag == 0 && playball==true && nokori>0)
        {
            pitch.pit = 1;
            count.flag = 0;
            Invoke("Shot", 6f);
            bflag = 1;

            var = Random.Range(3, piccher);
            hint = 1;
            nokori--;

        }
        if( bflag==0 && nokori == 0)
        {
            resultcamera.SetActive(true);
            bgm.SetActive(false);
            Scoreboard.resultview = true;
        }

    }


    public void Shot()
    {

        //ヒントの非表示
        hint = 0;

        //rotの変更
        //スローボール
        if (var == 4)
        {
            //rot = 20f;
            rot = 11f;
        }
        //カーブ
        else if (var == 5)
        {
            rot = 11f;

        }
        else if (var == 6)
        {
            rot = 0f;
        }
        else if (var == 7)
        {
            rot = 0f;
        }
        else if (var == 8)
        {
            rot = 0f;

        }
        else if (var == 9)
        {
            rot = 0;
        }
        else
        {
            rot = 11f;
        }

        transform.rotation = Quaternion.Euler(rot, 0f, 0f);

        
        // プレファブから砲弾(Shell)オブジェクトを作成し、それをshellという名前の箱に入れる。
        GameObject shell = (GameObject)Instantiate(shellPrefab, transform.position, Quaternion.identity);

        // Rigidbodyの情報を取得し、それをshellRigidbodyという名前の箱に入れる。
        Rigidbody shellRigidbody = shell.GetComponent<Rigidbody>();

        // shellRigidbodyにz軸方向の力を加える。
        shellRigidbody.AddForce(transform.forward * shotSpeed * (-1));

        //効果音
        AudioSource.PlayClipAtPoint(shotSound, new Vector3(0f,0f,0f));
    }



}

