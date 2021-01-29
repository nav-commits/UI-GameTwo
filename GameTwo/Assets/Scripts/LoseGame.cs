using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGame : MonoBehaviour
{

    public Box Box;
    public float speed = 5f;

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
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0f, 4f);
        transform.position += movement * speed * Time.deltaTime;
    }

    private void Awake()
    {
        Box = FindObjectOfType<Box>();
    }

}
