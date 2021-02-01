using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGame : MonoBehaviour
{

    public Box Box;
    public float speed = 1f;
    public bool dirRight;
    public float gametime;
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (Box.score < 3)
        {
            SceneManager.LoadScene("GameOver");
        }

        Box.Lose();
        Destroy(collision.gameObject);

       
    }



    public void Update()
    {
     
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);


        if (transform.position.x >= 11.47f)
        {
            dirRight = false;
        }

        if (transform.position.x <= -11.47)
        {
            dirRight = true;
        }


    }

    private void Awake()
    {
        Box = FindObjectOfType<Box>();
    }

}

