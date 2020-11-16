using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class enemyscript : MonoBehaviour
{
    
    public AIPath aiPath;

     SpriteRenderer sr;
    

    void Start()
    {
        sr=GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f)
        {
            //transform.localScale= new Vector3(1f, 1f, 1f);
            sr.flipX = false;
        }
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            //transform.localScale = new Vector3(-1f, 1f, 1f);
            sr.flipX = true;
        }

        
    }
    
}
