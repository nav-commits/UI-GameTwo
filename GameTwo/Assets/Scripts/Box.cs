using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    public bool lose = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if(score >= 2)
        {
            youWin();
        }

        
    }

   

    private void youWin()
    {
        ScoreText.text = "YOU WIN";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Addscore();
        Destroy(other.gameObject);
    }


    public void Addscore()
    {
        score++;
        ScoreText.text = "Score:"+ score.ToString();
    }
}
