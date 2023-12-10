using UnityEngine;

public class DogController : MonoBehaviour
{
    public AudioClip barkSound;
    public AudioClip treatSound;
    public GameObject treatPrefab;
    public Animator dogAnimator; 

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            MakeNoise();
            GiveTreat();
            PlaySecondSound();
        }
    }

    private void MakeNoise()
    {
        if (barkSound != null)
            audioSource.PlayOneShot(barkSound);
    }

    private void GiveTreat()
    {
        if (treatSound != null)
            audioSource.PlayOneShot(treatSound);

        if (treatPrefab != null)
        {
            GameObject treat = Instantiate(treatPrefab, transform.position, Quaternion.identity);
            Destroy(treat, 3f);
        }
        
        if (dogAnimator != null)
            dogAnimator.SetTrigger("turning_cockier_spanier");
    }

    private void PlaySecondSound()
    {
        audioSource.PlayOneShot(barkSound);
    }
}


