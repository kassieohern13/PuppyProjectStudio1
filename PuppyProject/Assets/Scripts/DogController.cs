using UnityEngine;

public class DogController : MonoBehaviour
{
    public AudioClip barkSound;
    public AudioClip treatSound;
    public GameObject treatPrefab; // Reference to the treat prefab

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
            // Instantiate the treatPrefab at the dog's position
            GameObject treat = Instantiate(treatPrefab, transform.position, Quaternion.identity);

            // Destroy the treat after a certain delay (adjust as needed)
            Destroy(treat, 3f);
        }
    }

    private void PlaySecondSound()
    {
        // Add your code to play the second sound here
        // Example: audioSource.PlayOneShot(secondSound);
    }
}

