using UnityEngine;
using UnityEngine.Audio;

public class ChangeMusicOnTrigger : MonoBehaviour
{
    public AudioMixerSnapshot snapshotBosque;
    public AudioMixerSnapshot snapshotExterior;



    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            print("Trigger bosque");
            snapshotBosque.TransitionTo(2.0f); // Cambia a la música misteriosa al entrar al bosque
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("Trigger exterior");
            snapshotExterior.TransitionTo(2.0f); // Cambia a la música relajante al salir del bosque
        }
    }
}
