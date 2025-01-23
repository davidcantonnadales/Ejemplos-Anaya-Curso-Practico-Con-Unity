using UnityEngine;

public class MovimientoControlado : MonoBehaviour
{
    public Vector3 puntoDestino;
    public float velocidad = 5f;

    void Update()
    {
        // Mueve el objeto hacia el punto de destino a una velocidad constante
        transform.position = Vector3.MoveTowards(transform.position, puntoDestino, velocidad * Time.deltaTime);
    }

}
