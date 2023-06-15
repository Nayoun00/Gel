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
        float moveAmount = 15 * Time.fixedDeltaTime;
        transform.Translate(Vector2.up * moveAmount);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Monster")
        {
            other.GetComponent<MonsterCtrl>().GetDmg(1);
            Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        if (this.transform.position.y > 50)
        {
            Destroy(this.gameObject);
        }
    }
}
