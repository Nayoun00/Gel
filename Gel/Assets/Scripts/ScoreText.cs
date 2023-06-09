using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public TMP_Text text;
    [SerializeField]
    GameManager manager;
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        int score = manager.count;
        text.text = "Score : " + score.ToString();
    }
}
