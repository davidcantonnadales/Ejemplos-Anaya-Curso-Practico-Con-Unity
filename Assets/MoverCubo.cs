using DG.Tweening; // Necesario para usar DOTween
using UnityEngine;

public class MoverCubo : MonoBehaviour
{
    public Vector3 destino;
    public float duracion = 2f;

    void Start()
    {
        // Iniciar la animación de movimiento hacia la posición de destino
        transform.DOMove(destino, duracion);
    }
}
