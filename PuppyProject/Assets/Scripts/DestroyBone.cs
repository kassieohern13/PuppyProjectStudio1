using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBone : MonoBehaviour

{
 
    public string boneTag = "Bone";

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Dog"))
        {
            Destroy(gameObject);
        }
    }
}