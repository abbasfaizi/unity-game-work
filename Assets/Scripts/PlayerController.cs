using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float moveSpeed;
    public bool isMoving;
    private Vector2 input;
    
    
   

    // Update is called once per frame
    void Update()
    {
        if (!isMoving) {
            input.x = Input.GetAxisRaw("Horizontal");
            input.x = Input.GetAxisRaw("Vertical");
        }
    }
}
