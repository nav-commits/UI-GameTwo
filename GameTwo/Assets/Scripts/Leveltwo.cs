using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Leveltwo : MonoBehaviour

{

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
        if (score == 5 || score == 4 || score == 3)
        {
            WinGame();


        }

        if(score == 2)
        {

            ScoreText.text = "You are Losing :" + score.ToString();
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        addScore();
        Destroy(collision.gameObject);
        sprites.color = new Color(2, 0, 0, 1);
   
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


