using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleTwo : MonoBehaviour
{
    [SerializeField] float screenWidthunits = 16f;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        float Movemouse = Input.mousePosition.x / Screen.width * screenWidthunits;
        Vector2 paddlepos = new Vector2(Movemouse, transform.position.y);
        transform.position = paddlepos;
    }
}

