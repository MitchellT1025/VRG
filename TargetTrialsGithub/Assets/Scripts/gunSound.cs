using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunSound : MonoBehaviour
{

    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        source.Play();
        Debug.Log("audio.Play Called");
    }
}
