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

    void Start()

    {
        score = 9;
        ScoreText.text = "Player Score:" + score.ToString();

    }

    void Update()

    {
       
    }


    public void DestoryScore()
    {
       
        score--;

        for (int i = 0; i > score; i++)
        {
            PlayerScore[i].SetActive(false);
            Debug.Log("HELLO");
        }

        //if (score < 5)
        //{
        //    PlayerScore[0].SetActive(false);
        //}

        //if (score < 4)
        //{
        //    PlayerScore[1].SetActive(false);
        //}

        //if (score < 3)
        //{
        //    PlayerScore[2].SetActive(false);
        //}

        //if (score < 2)
        //{
        //    PlayerScore[3].SetActive(false);
        //}

        //if (score < 1)
        //{
        //    PlayerScore[4].SetActive(false);
        //}


        ScoreText.text = "Player Score:" + score.ToString();

        if(score == 0)
        {
            GameOver();
        }
    }



    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }


    public void WinGame()
    {
        SceneManager.LoadScene("Win");
    }

}


