using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    GameManager manager;


    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        float speed = manager.speed * 2;
        rb.velocity = new Vector2(rb.velocity.x, speed);

        if (this.gameObject.transform.position.y <= -34)
        {
            this.gameObject.transform.position = new Vector3(-3.487854f , 86, 1);
        }
    }
}
