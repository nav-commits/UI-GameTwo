using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TrackScore : MonoBehaviour
{
    public GameObject[] PlayerScore;
    public Text ScoreText;
    public int score;

   
    void Start()
    {
        score = 10;
        ScoreText.text = "Player Score:" + score.ToString();
    }


    void Update()
    {

    }


    public void DestoryScore()
    {

        score--;
        PlayerScore[0].SetActive(false);

        // making sure score doesnt go past 0
        if(score == -1)
        {
            score = 0;
            ScoreText.text = " Player Score:" + score.ToString();
        }

        ScoreText.text = "Player Score:" + score.ToString();
    }
}