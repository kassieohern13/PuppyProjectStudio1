using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBone : MonoBehaviour

{
    public string boneTag = "Bone";
    public AudioClip onAwakeSound;
    public AudioSource audioSource;

    private void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();

        if (onAwakeSound != null)
        {
            audioSource.clip = onAwakeSound;
            audioSource.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Dog"))
        {
            Destroy(gameObject);
        }
    }
}