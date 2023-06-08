using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{

    public Rigidbody2D rb;

    public GameObject bullet;

    public float moveSpeed = 20.0f;
    public int hp = 3;
        

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bullet = Resources.Load("Bullet") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y, 0);
        //플레이어 이동
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject temp = (GameObject)Instantiate(bullet);
            temp.transform.position = this.gameObject.transform.position;
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
