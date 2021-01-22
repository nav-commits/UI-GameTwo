using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float minX = -8f;
    [SerializeField] float maxX = 10f;
    [SerializeField] float screenWidthUnits = 16f;
   

    void Start()
    {
        
    }

   
    void Update()
    {
       float mouseposUnits = Input.mousePosition.x / Screen.width * screenWidthUnits;
       Vector2 paddlepos = new Vector2(mouseposUnits, transform.position.y);
       transform.position = paddlepos;
      
    }

   

}






