using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class ScoreLogic : Singleton<ScoreLogic>
{
    private int score = 0;
    [SerializeField]private Text scoreText;

    private void Start()
    {
        Instance.ScoreText = scoreText;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
    public Text ScoreText
    {
        get { return scoreText; }
        set { scoreText = value; }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
