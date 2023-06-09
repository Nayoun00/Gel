using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpwan : MonoBehaviour
{
    //장애물 스폰

    [SerializeField]
    private Object[] Enemy;
    [SerializeField]
    private GameObject Enemy1, Enemy2, Enemy3, Enemy4;


    float currTime;



    void Update()
    {
        Enemy = Resources.LoadAll("Enemy");
        for (int i = 0; i < Enemy.Length; i++)
        {
            switch (i)
            {
                case 0:
                    Enemy1 = Enemy[i] as GameObject; break;
                case 1:
                    Enemy2 = Enemy[i] as GameObject; break;
                case 2:
                    Enemy3 = Enemy[i] as GameObject; break;
                case 3:
                    Enemy4 = Enemy[i] as GameObject; break;
            }
        }

        //랜덤 스폰
        currTime += Time.deltaTime;
        if (currTime > 1.0f)
        {
            float newX = Random.Range(2f, 28f), newY = Random.Range(46f, 66f);
            int type = Random.Range(0, 4);

            switch (type)
            {
                case 0:
                    GameObject B1 = (GameObject)Instantiate(Enemy1);
                    B1.transform.position = new Vector2(newX, newY);
                    break;
                case 1:
                    GameObject B2 = (GameObject)Instantiate(Enemy2);
                    B2.transform.position = new Vector2(newX, newY);
                    break;
                case 2:
                    GameObject B3 = (GameObject)Instantiate(Enemy3);
                    B3.transform.position = new Vector2(newX, newY);
                    break;
                case 3:
                    GameObject B4 = (GameObject)Instantiate(Enemy4);
                    B4.transform.position = new Vector2(newX, newY);
                    break;
            }
            currTime = 0;
        }
    }

}
