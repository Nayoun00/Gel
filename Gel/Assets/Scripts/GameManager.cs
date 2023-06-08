using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int count;

    private void Update()
    {
        if(count >= 2)
        {
            MoveScene("Play2");
        }
    }
    // Start is called before the first frame update
    public void MoveScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
