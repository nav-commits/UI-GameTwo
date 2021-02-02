using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Leveltwo : MonoBehaviour

{
    public GameObject [] PlayerScore;
    public Text ScoreText;
    public int score;
    SpriteRenderer sprites;

    void Start()

    {
        score = 0;
        ScoreText.text = "Player Score:" + score.ToString();
        sprites = GetComponent<SpriteRenderer>();
    }

    void Update()

    {
       if(score == 2)
        {
            WinGame();
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        addScore();
        Destroy(collision.gameObject);
        sprites.color = new Color(2, 0, 0, 1);
    }




    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }


    public void WinGame()
    {
        SceneManager.LoadScene("Win");
    }

    private void addScore()
    {
        score++;
        ScoreText.text = "Player Score:" + score.ToString();
    }

}


