using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using System;

[RequireComponent(typeof(ActionBasedController))]
public class gunShoot : MonoBehaviour
{

    public RaycastHit hit;
    
    public GameObject impactEffect;
    AudioSource source;
    public Transform gunHole;


    float fireElapsedTime = 1;
    public float fireDelay = 1f;
    public float damage = 5f;

    

    void Start()
    {

        source = GetComponent<AudioSource>();

    }

    void Update()
    {

    }


    void FireRate()
    {
        fireElapsedTime += Time.deltaTime;
        //if your last shot was less than the timer then you cant shoot yet

        /* if (Input.GetMouseButtonDown(0) && fireElapsedTime >= fireDelay)
         {
             fireElapsedTime = 1;
             Shoot();
         }*/
    }

   public void Shoot()
    {

         

        source.Play();
        if (Physics.Raycast(gunHole.position, gunHole.forward, out hit, Mathf.Infinity))
        {
            Debug.Log("Shot");
            GameObject impactGo = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGo, 1);
            if (hit.collider.gameObject.tag == "Target")
            {
                Debug.Log("Target detected");
                Target target = hit.collider.gameObject.GetComponent<Target>();
                target.TakeDamage(damage);

            }
        }





    }

}



