using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager thisManager;
    private int Score = 0;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        thisManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore()
    {
        Score++;
        ScoreText.text = "Score : " + Score;
    }

    public void GameOver()
    {
        SceneManager.LoadScene(1);
    }
}
