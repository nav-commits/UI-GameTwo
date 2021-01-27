using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Box : MonoBehaviour
{
 
    public Text ScoreText;
    SpriteRenderer sprite;
    public int score;
    public GameObject[] Boxes;
    public GameObject[] Balls;
    public bool draw;
   
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        draw = false;
        ScoreText.text = "Player Score:" + score.ToString();
    }

  
    void Update()
    {

        if (score > 2)
        {
            YouWin();
            
        }

   
        if (score == 2 || score == 3)
        {
            ScoreText.text = "Need One more to win!";
            draw = true;
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
