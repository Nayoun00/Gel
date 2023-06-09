using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonsterCtrl : MonoBehaviour
{
    public int hp = 5;
    public float LeftTimer = 2.0f;
    public bool isLeft = false;
    public float nextFireTime;
    public float fireRate = 1.0f;
    public GameObject bullet;

    Rigidbody2D rb;
    [SerializeField]
    GameManager manager;

    private void Start()
    {
        bullet = Resources.Load("Monster_B") as GameObject;
        int LorR = Random.Range(0, 2);
        if (LorR == 0) isLeft = true;
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();

        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        LeftTimer-= Time.fixedDeltaTime;
        if(LeftTimer <= 0 )
        {
            if (isLeft == false)
            {
                isLeft = true;
            }
            else
            {
                isLeft = false;
            }
            LeftTimer = Random.Range(0.2f, 1.0f);  //0.2f;
        }
    }
    private void Update()
    {
        float speed = manager.speed;
        rb.velocity = new Vector2(rb.velocity.x, speed);

        if (this.transform.position.y < -14)
        {
            Destroy(this.gameObject);
        }
        if (isLeft == true)
        {
            rb.velocity = new Vector2(-2, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(2, rb.velocity.y);
        }
        if(this.gameObject.tag == "BadAssMonster")
        {
            if (Time.time > nextFireTime)
            {
                nextFireTime = Time.time + 1.0f / fireRate;
                GameObject B3 = (GameObject)Instantiate(bullet);
                B3.transform.position = this.gameObject.transform.position;
            }
        }
    }

            public void GetDmg(int d)
    {
        hp -= d;
        if (hp <= 0)
        {
            manager.Counting();
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
