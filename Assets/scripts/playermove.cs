using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float xVelocity=0;
        float yVelocity=0;
        float speed = 5;
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            xVelocity=-speed;
        }
        else
        {
            
        }
        
        if(Input.GetKey(KeyCode.RightArrow))
        {          
            xVelocity=speed;
        }
        else
        {

        }
        
        if(Input.GetKey(KeyCode.UpArrow))
        {
            yVelocity=speed;
        }
        else
        {

        }
        
        if(Input.GetKey(KeyCode.DownArrow))
        {
            yVelocity=-speed;
        }
        else
        {

        }
        rb.velocity = new Vector2(xVelocity,yVelocity);

        
    }

    private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.gameObject.CompareTag("chicken"))
            {
                Destroy(other.gameObject);
            }
        }

    
}
