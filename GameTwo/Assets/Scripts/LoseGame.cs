using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGame : MonoBehaviour
{

    public Box Box;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (Box.score == -3 || Box.score == -1)
        {
            SceneManager.LoadScene("GameOver");
            Destroy(collision.gameObject);
        }

        Box.Lose();

        Destroy(collision.gameObject);
    }



    private void Awake()
    {
        Box = FindObjectOfType<Box>();
    }

}
