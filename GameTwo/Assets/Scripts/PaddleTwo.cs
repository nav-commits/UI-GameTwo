using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleTwo : MonoBehaviour
{
    [SerializeField] float screenWidthunits = 16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Movemouse = Input.mousePosition.x / Screen.width * screenWidthunits;
        Vector2 paddlepos = new Vector2(Movemouse, transform.position.y);
        transform.position = paddlepos;
    }
}

