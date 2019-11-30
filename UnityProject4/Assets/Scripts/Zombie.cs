
using UnityEngine;

public class Zombie : MonoBehaviour
{
    [Header("血量")]
    public float Hp;
    [Header("攻擊")]
    public float Atk;
    [Header("攻擊音效")]
    public AudioClip atkclip;
    [Header("攻擊音響")]
    public AudioSource atkSourse;
    [Header("玩家腳本")]
    public Player _Player;
    int DeadCount;
    private void Awake()
    {
        _Player = GameObject.Find("小屁孩").GetComponent<Player>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)&&Hp > 0)
        {
            Hurt();
        }
        if (Hp <= 0&&DeadCount < 1)
        {

            Dead();
            DeadCount = 1;

        }
    }
    public void Hurt()
    {
        if (_Player.Hp <= 0)
        {

            return;
        }
        atkSourse.PlayOneShot(atkclip);
        _Player.Hp -= (Random.Range(0, 10));
        print("玩家受到傷害" + Random.Range(0, 10));

        if (_Player.Hp > 0)
        {
            print("殭屍剩於血量" + _Player.Hp);
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
            print("我會再來的~~~");
        }

    }
}
