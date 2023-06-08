using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveAmount = 10 * Time.fixedDeltaTime;
        transform.Translate(Vector2.up * moveAmount);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Monster") 
        {
            other.GetComponent<MonsterCtlr>().GetDmg(1);
            Destroy(this.gameObject);
        }
    }

}
