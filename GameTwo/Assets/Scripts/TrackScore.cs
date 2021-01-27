using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrackScore : MonoBehaviour
{
    public GameObject[] PlayerScore;
    public Text ScoreText;
    public int score;

   
    void Start()
    {
        score = 5;
        ScoreText.text = "Player Score:" + score.ToString();
    }

    void Update()
    {

    }

    public void DestoryScore()
    {

        score--;

        for(int i = 0; i <PlayerScore.Length; i++)
        {
            if (score < 5)
            {
                PlayerScore[i].SetActive(false);
            }

            else
            {
                PlayerScore[i].SetActive(true);
            }
        }

      
        if(score == -1)
        {
            score = 0;
        }

        ScoreText.text = "Player Score:" + score.ToString();

        if(score == 0)
        {
            BackHome();
        }
    }


    public void BackHome()
    {
        SceneManager.LoadScene("GameOver");
    }
}


