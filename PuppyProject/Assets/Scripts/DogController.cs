using UnityEngine;

public class DogController : MonoBehaviour
{
    public AudioClip barkSound;
    public AudioClip treatSound;
    public GameObject treatPrefab;
    public Animator dogAnimator; // Reference to the Animator component

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

        // Trigger the "ReceiveTreat" animation
        if (dogAnimator != null)
            dogAnimator.SetTrigger("ReceiveTreat");
    }

    private void PlaySecondSound()
    {
        // Add your code to play the second sound here
        audioSource.PlayOneShot(barkSound);
    }
}


