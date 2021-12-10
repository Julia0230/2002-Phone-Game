using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IS_Move2 : MonoBehaviour
{
    Rigidbody2D body;

    
    float moveLimiter = 0.7f;

    public float runSpeed = 20.0f;
    //joystick
    public bl_Joystick joystick;
    private GameObject hoestick;
    float horizontal;
    float vertical;
  //float horizontal2;
  //float vertical2;
    private bool facingleft;
    private Animator anime; 
    public Sprite first;
    private SpriteRenderer render;
    

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        //joystick
        hoestick= GameObject.Find("Joystick");
        joystick= hoestick.GetComponent<bl_Joystick>();
        //animator
        anime = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Gives a value between -1 and 1
        //horizontal2 = Input.GetAxisRaw("Horizontal"); // -1 is left
       // vertical2 = Input.GetAxisRaw("Vertical"); // -1 is down
        horizontal = joystick.Horizontal;
        vertical = joystick.Vertical;
    }

    void FixedUpdate()
    { Vector2 localScale = transform.localScale;
        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
        {   anime.enabled= true;
            // limit movement speed diagonally, so you move at 70% speed
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }
        else
        {
            anime.enabled = false;
            render.sprite = first;

        }
      
    if(horizontal <-0.1)
{
    facingleft=true;}
    else if(horizontal >0.1)
  { facingleft=false;

  }
  
if (((facingleft ) && (localScale.x < 0 )) || ((!facingleft) && (localScale.x > 0 ))) 
{
         localScale.x *= -1;}


        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);

transform.localScale = localScale;
    }
}
