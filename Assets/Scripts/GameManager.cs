using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateScore()
    {
        score++;
        scoreText.text=score.ToString();

    }

    public void ReStartGame()
    {
        SceneManager.LoadScene(0);
    }
}
