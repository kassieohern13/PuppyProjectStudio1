 using UnityEngine;
using System.Collections;
 
public class Noise : MonoBehaviour
{
 
    [SerializeField] private AudioSource _as;
    [SerializeField] private AudioClip _dogWhine;
 
    void Start()
    {
 
    }
 
    void Update()
    {
 
    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
 
            Destroy(gameObject);
 
            _as.PlayOneShot(_dogWhine);
        }
    }
}