using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    SpriteRenderer sprite;


    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

  
    void Update()
    {
      
        if(score >= 1)
        {
            youWin();
        }
        
    }
  
    private void youWin()
    {
        ScoreText.text = "YOU WIN";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Addscore();
        Destroy(collision.gameObject);
        sprite.color = new Color(2, 0, 0, 1);
    }

    

    public void Addscore()
    {
        score++;
        ScoreText.text = "Score:"+ score.ToString();
    }
}
