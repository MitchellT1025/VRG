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


    float fireElapsedTime;
    public float fireDelay = 1f;
    public float damage = 5f;
    private bool fireReady;

    

    void Start()
    {
        Debug.Log(gameObject.name);
        source = GetComponent<AudioSource>();
        fireReady = true;
    }

    void Update()
    {
        if(!fireReady) fireElapsedTime += Time.deltaTime;
        if (fireElapsedTime >= fireDelay) fireReady = true;

    }


    public void FireRate()
    {
        if (fireReady) Shoot();
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
        fireElapsedTime = 0;
        fireReady = false;

    }

}



