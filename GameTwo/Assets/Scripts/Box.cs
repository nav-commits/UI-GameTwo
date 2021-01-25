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


    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    
    }

  
    void Update()
    {

        if (score >= 2)
        {
            YouWin();
        }

       

        if (Input.GetMouseButton(0))
        {
           
            foreach(GameObject boxes in Boxes)
            {
                boxes.SetActive(false);
               
            }


        }
    }
  
    private void YouWin()
    {
        ScoreText.text = "YOU WIN";
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
        ScoreText.text = "Score:" + score.ToString();
    }
}
