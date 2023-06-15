using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBullet : MonoBehaviour
{
    void FixedUpdate()
    {
        float moveAmount = -7 * Time.fixedDeltaTime;
        transform.Translate(Vector2.down * moveAmount);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<PlayerCtrl>().GetDmg(1);
            Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        if (this.transform.position.y < -50)
        {
            Destroy(this.gameObject);
        }
    }
}
