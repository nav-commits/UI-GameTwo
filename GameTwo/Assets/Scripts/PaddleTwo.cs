using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleTwo : MonoBehaviour
{
    [SerializeField] float screenWidthunits = 16f;
    [SerializeField] float minX = -2f;
    [SerializeField] float minY = 8f;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        float Movemouse = Input.mousePosition.x / Screen.width * screenWidthunits;
        Vector2 paddlepos = new Vector2(Movemouse, transform.position.y);
        paddlepos.x = Mathf.Clamp(Movemouse, minX, minY);
        transform.position = paddlepos;
    }
}

