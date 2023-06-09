using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterType : MonoBehaviour
{
    public float timer = 1.5f;
    [SerializeField]
    GameObject[] monsters = new GameObject[22];
    private void FixedUpdate()
    {
        timer-=Time.fixedDeltaTime;
        if(timer <= 0 )
        {
            int type = Random.Range(0, monsters.Length);
            SpawnMonster(type);
            timer = 1.5f;
        }
    }
    public void SpawnMonster(int a)
    {
        float newX = Random.Range(2f, 28f), newY = Random.Range(46f, 66f);
        GameObject monster = (GameObject)Instantiate(monsters[a]);
        monster.transform.position = new Vector2(newX, newY);
    }
}
