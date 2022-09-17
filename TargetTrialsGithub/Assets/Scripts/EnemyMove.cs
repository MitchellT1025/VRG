using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{


    public float delta = 1.5f;  // Amount to move left and right from the start point
    public float speed = 2.0f;
    private Vector3 startPos;
   public bool Enemy = true;

    void Start()
    {
        startPos = transform.position;
       
    }

    void Update()
    {
        Move();
       /* if(Enemy = true)
        {
            
            Enemy = false;
        }*/
    }
    public void Move()
    {
        Vector3 v = startPos;
        v.y += delta * speed; // * Time.deltaTime;
        transform.position = v; 

        /*if (this.transform.y != 1.5)
        {
            this.transform.y++;
            Enemy.true;
        }
        else if (this.transform.y == 1.5)
        {
            Enemy = false;
        }*/
    }
    
}

