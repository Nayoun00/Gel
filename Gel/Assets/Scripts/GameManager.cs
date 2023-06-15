using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int count;
    public float speed = -2;
    // Start is called before the first frame update
    public void MoveScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    public void Counting()
    {
        count++;
        switch (count)
        {
            case 0:
                speed -= 0.7f;
                break;
            case 1:
                speed -= 0.7f;
                break;
            case 2:
                speed -= 0.7f;
                break;
            case 3:
                speed -= 0.7f;
                break;
            case 10:
                MoveScene("Clear");
                break;

        }
    }
}
