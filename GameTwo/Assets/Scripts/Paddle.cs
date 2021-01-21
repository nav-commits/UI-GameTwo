using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthUnits = 16f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Screen Width : " + Screen.width);
    }

    // Update is called once per frame
    void Update()
    {
       float mouseposUnits = Input.mousePosition.x / Screen.width * screenWidthUnits;
       Vector2 paddlepos = new Vector2(mouseposUnits, transform.position.y);
       paddlepos.x = Mathf.Clamp(mouseposUnits, minX, maxX);
       transform.position = paddlepos;

    }
}
