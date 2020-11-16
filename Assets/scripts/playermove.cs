using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playermove : MonoBehaviour
{
    public int keys = 0;
    private Animator anim;
    private Rigidbody2D rb;

    public Text keyAmount;
    public Text winner;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float xVelocity=0;
        float yVelocity=0;
        float speed = 5;
        
        
        
        if(Input.GetKey(KeyCode.RightArrow))
        {    
            anim.SetBool("walk right", true); 
            anim.SetBool("idle", false);     
            xVelocity=speed;
        }
        else
        {
            anim.SetBool("walk right", false);
            anim.SetBool("idle", true);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("walk left", true);
            anim.SetBool("idle", false);
            xVelocity=-speed;
        }
        else
        {
            anim.SetBool("walk left", false);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("walk right", true);
            anim.SetBool("idle", false);
            yVelocity=speed;
        }
        else
        {

        }
        
        if(Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("walk right", true);
            anim.SetBool("idle", false);
            yVelocity=-speed;
        }
        else
        {

        }

        if(Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("walk right", false);
            anim.SetBool("walk left", false);
            xVelocity= 0;
        }

        if(Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("walk right", false);
            anim.SetBool("walk left", true);
            //xVelocity= speed;
        }

        rb.velocity = new Vector2(xVelocity,yVelocity);

        
    }

    private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.gameObject.CompareTag("key"))
            {
                keys++;
                keyAmount.text = "Keys: " + keys;
                Destroy(other.gameObject);
            }

            if(other.gameObject.CompareTag("enemy"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

            if(other.gameObject.CompareTag("chicken"))
            {
                Destroy(other.gameObject);
            }

            if(other.gameObject.CompareTag("door") && keys == 3)
            {
                Destroy(other.gameObject);
            }

            if(other.gameObject.CompareTag("golden skull"))
            {
                winner.text = "Well done you successfully collected the Golden Skull!";
                Destroy(other.gameObject);

            }
        }

    
}
