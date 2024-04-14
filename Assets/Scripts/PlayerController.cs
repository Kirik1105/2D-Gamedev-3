using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmmout=1;
    [SerializeField] float boostSpeed=1;
    [SerializeField] float baseSpeed=1;    
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;

    bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (canMove)
        {
          RotatePlayer();
          PlayerBuster();  
        }
        
    }
    
    public void DisableControls(){
        canMove=false;
    }
    void PlayerBuster(){
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed=boostSpeed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            surfaceEffector2D.speed=baseSpeed;
        }
    }
    void RotatePlayer(){
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmmout);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmmout);
        }
    }
}