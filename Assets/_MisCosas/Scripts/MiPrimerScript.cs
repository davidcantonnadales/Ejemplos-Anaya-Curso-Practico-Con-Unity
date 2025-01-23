using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{
    // Velocidad de rotación
    public float rotationSpeed = 100f;

    // Update se llama una vez por frame
    void Update()
    {
        // Rotar la esfera alrededor del eje Y
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        print(rotationSpeed);
    }

    private void Start()
    {
        print("Hola Mundo");
    }
}
