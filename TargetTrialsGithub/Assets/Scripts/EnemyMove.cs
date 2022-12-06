using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{


    private float riseSpeed;
    private float decendSpeed;
    private Vector3 startPos, endPos;
    private float currentTime, lifeTime;
    public float heightAbove;
    private bool isAboveGround;
    
    void Start()
    {
        startPos = transform.position;
        endPos = new Vector3(transform.position.x, transform.position.y + heightAbove, transform.position.z);
        lifeTime = Random.Range(1, 5);
        riseSpeed = Random.Range(.5f, 2);
        decendSpeed = Random.Range(.5f, 2);
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= lifeTime)
        {
            isAboveGround = true;
        }
        if (!isAboveGround)
        {
            transform.position = Vector3.Lerp(transform.position, endPos, riseSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, startPos, decendSpeed * Time.deltaTime);
            
            if(Vector3.Distance(startPos, transform.position) <= .1f)
            {
                
                currentTime = 0;
                isAboveGround = false;
            }
        }
    }
    public void Move()
    {
        

        
    }
    private IEnumerator DummyBob()
    {
       
        yield return new WaitForSeconds(lifeTime);
       
    }
}

