using UnityEngine;

public class HealthDamager : MonoBehaviour
{
    public float damageAmount = 10f;

    private void OnTriggerEnter(Collider other)
    {
        Life life = other.GetComponent<Life>();

        if (life != null)
        {
            life.health -= damageAmount;
        }
    }
}
