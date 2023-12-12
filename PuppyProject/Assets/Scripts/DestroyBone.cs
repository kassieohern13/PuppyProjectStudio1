using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBone : MonoBehaviour

{
 
    public string boneTag = "bone";

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("dog"))
        {
          
            GameObject[] boneObjects = GameObject.FindGameObjectsWithTag(boneTag);

            foreach (GameObject boneObject in boneObjects)
            {
                Destroy(boneObject);
                Debug.Log("Destroyed: " + boneObject.name);
            }
        }
    }
}