using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    GameManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float speed = manager.speed*2;
        rb.velocity = new Vector2(rb.velocity.x, speed);

        if (this.transform.position.y < -14)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
           other.GetComponent<PlayerCtrl>().GetDmg(1);
            Destroy(this.gameObject);
        }
    }
}
