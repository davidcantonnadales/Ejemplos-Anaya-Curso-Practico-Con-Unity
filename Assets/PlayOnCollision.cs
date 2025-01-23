using UnityEngine;

public class PlayOnCollision : MonoBehaviour
{
    public AudioSource impactSound;

    private void Awake()
    {
        impactSound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        print("Collision detected");
        impactSound.Play();
    }

    void OnTriggerEnter(Collider other)
    {
        print("Trigger detected");
        impactSound.Play();
    }
}
