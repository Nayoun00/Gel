using System.Collections;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public Rigidbody2D rb;

    public float moveSpeed = 20.0f;
    public int hp = 3;


    private Object[] Bullet;
    private GameObject Bullet1, Bullet2, Bullet3, Bullet4;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Bullet = Resources.LoadAll("Bullet");
        for(int i = 0; i < Bullet.Length; i++)
        {
            switch (i)
            {
                case 0:
                    Bullet1 = Bullet[i] as GameObject; break;
                case 1:
                    Bullet2 = Bullet[i] as GameObject; break;
                case 2:
                    Bullet3 = Bullet[i] as GameObject; break;
                case 3:
                    Bullet4 = Bullet[i] as GameObject; break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y, 0);
        //플레이어 이동
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int type = Random.Range(0, 4);
            switch(type)
            {
                case 0:
                    GameObject B1 = (GameObject)Instantiate(Bullet1);
                    B1.transform.position = this.gameObject.transform.position;
                    break;
                case 1:
                    GameObject B2 = (GameObject)Instantiate(Bullet2);
                    B2.transform.position = this.gameObject.transform.position;
                    break;
                case 2:
                    GameObject B3 = (GameObject)Instantiate(Bullet3);
                    B3.transform.position = this.gameObject.transform.position;
                    break;
                case 3:
                    GameObject B4 = (GameObject)Instantiate(Bullet4);
                    B4.transform.position = this.gameObject.transform.position;
                    break;
            }
        }

    }

    public void GetDmg(int d)
    {
        if (hp > 0)
        {
            hp -= d;
        }
        else
        {
            PlayerDie();
        }
    }

    void PlayerDie()
    {

    }


}
