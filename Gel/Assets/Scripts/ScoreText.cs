using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public TMP_Text text;
    [SerializeField]
    GameManager manager;
    GameObject player;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        player = GameObject.FindWithTag("Player");
        text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        int score = manager.count;
        int hp = player.GetComponent<PlayerCtrl>().hp;
        text.text = "Score : " + score.ToString() + " Hp : " + hp.ToString();

    }
}
