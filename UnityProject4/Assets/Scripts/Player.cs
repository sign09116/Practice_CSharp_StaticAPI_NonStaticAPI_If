
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("玩家血量")]
    public float Hp;
    [Header("玩家攻擊")]
    public float Atk;
    [Header("玩家攻擊音效")]
    public AudioClip atkclip;
    [Header("玩家攻擊音響")]
    public AudioSource atkSourse;
    [Header("殭屍腳本")]
    public Zombie _Zombie;
    int DeadCount;
    private void Awake()
    {
        _Zombie = GameObject.Find("殭屍").GetComponent<Zombie>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Hurt();
        }
        if (Hp <= 0)
        {
            print("殭屍剩於血量" + 0);
            Dead();
            DeadCount = 1;

        }
    }
    public void Hurt()
    {
        if (_Zombie.Hp <= 0)
        {
            return;
        }

        atkSourse.PlayOneShot(atkclip);
        _Zombie.Hp -= (Random.Range(0, 10));
        print("殭屍受到傷害" + Random.Range(0, 10));
        if (_Zombie.Hp > 0)
        {
            print("殭屍剩於血量" + _Zombie.Hp);
        }
        else
        {
            print("殭屍剩於血量" + 0);
        }



    }
    public void Dead()
    {
        if (DeadCount < 1)
        {
            print("你死了~~~");
        }

    }
}
