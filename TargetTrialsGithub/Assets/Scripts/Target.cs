using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    AudioSource tinkTarget;
    public float health = 10f;
    

    void Start()
    {
        tinkTarget = GetComponent<AudioSource>();


    }
    public void TakeDamage(float damage)
    {
        Debug.Log("Hit");
        health -= damage;
        tinkTarget.Play();
        if (health <= 0)
        {
            Score.scoreCounter += 1;
            Destroy(gameObject);

        }
    }
}

