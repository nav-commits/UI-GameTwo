using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrackScore : MonoBehaviour

{
    public GameObject [] PlayerScore;
    public Text ScoreText;
    public int score;
    public int scoretwo;
    public Text ScoreTextTwo;
    public GameObject[] PlayerScoreTwo;
   

    void Start()

    {
        score = 5;
        ScoreText.text = "Player Score:" + score.ToString();

        scoretwo = 0;
        ScoreTextTwo.text = "Player Score:" + scoretwo.ToString();

    }

    void Update()

    {
       
    }

    public void DestoryScore()
    {
       
        score--;

        if (score < 5)
        {
            PlayerScore[0].SetActive(false);
        }

        if (score < 4)
        {
            PlayerScore[1].SetActive(false);
        }

        if (score < 3)
        {
            PlayerScore[2].SetActive(false);
        }

        if (score < 2)
        {
            PlayerScore[3].SetActive(false);
        }

        if (score < 1)
        {
            PlayerScore[4].SetActive(false);
        }


        ScoreText.text = "Player Score:" + score.ToString();

        if(score == 0)
        {
            GameOver();
        }
    }


    public void Points()
    {
        scoretwo++;

        if (scoretwo > 0)
        {
            PlayerScoreTwo[0].SetActive(true);
        }

        if (scoretwo > 1)
        {
            PlayerScoreTwo[1].SetActive(true);
        }

        if (scoretwo > 2)
        {
            PlayerScoreTwo[2].SetActive(true);
        }

        if (scoretwo > 3)
        {
            PlayerScoreTwo[3].SetActive(true);
        }

        if (scoretwo > 4)
        {
            PlayerScoreTwo[4].SetActive(true);
        }

        if (scoretwo > 5)
        {
            PlayerScoreTwo[5].SetActive(true);
        }



        if (scoretwo == 5)
        {
            WinGame();
        }

        ScoreTextTwo.text = "Player Score:" + scoretwo.ToString();
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


