using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBone : MonoBehaviour

{
    public string boneTag = "Bone";

    private void OnCollisionEnter(Collision collision)
    {
     
        if (collision.gameObject.CompareTag("Dog"))
        {
            GameObject[] boneObjects = GameObject.FindGameObjectsWithTag(boneTag);
            
            foreach (GameObject boneObject in boneObjects)
            {
                Destroy(boneObject);
            }
        }
    } 
    
    
}