﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Box : MonoBehaviour
{
 
    public Text ScoreText;
    SpriteRenderer sprite;
    public int score;
   [SerializeField] float gameSpeed = 1f;
   
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        ScoreText.text = "Player Score:" + score.ToString();
    }

  
    void Update()
    {
        Time.timeScale = gameSpeed;

        if (score > 2)

        {
            YouWin();
            
        }

    }
  
    private void YouWin()
    {
        ScoreText.text = "YOU WIN, NEXT LEVEL!!!";
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        AddScore();
        Destroy(collision.gameObject);
        sprite.color = new Color(2, 0, 0, 1);
    }

   
    public void AddScore()
    {
                
        score++;
        ScoreText.text = "Player Score:" + score.ToString();
    }
}
