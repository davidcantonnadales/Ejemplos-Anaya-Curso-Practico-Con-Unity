using UnityEngine;

public class RotarMover : MonoBehaviour
{
    public float velocidadRotacion = 50f; // Velocidad de rotación en grados por segundo
    public float velocidadMovimiento = 2f; // Velocidad de desplazamiento en unidades por segundo

    void Update()
    {
        // Aplicar rotación sobre el eje Y
        transform.Rotate(0, velocidadRotacion * Time.deltaTime, 0);

        // Desplazar el objeto hacia adelante en su eje Z
        transform.Translate(Vector3.forward * velocidadMovimiento * Time.deltaTime);
    }
}
