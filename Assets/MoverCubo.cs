using DG.Tweening; // Necesario para usar DOTween
using UnityEngine;

public class MoverCubo : MonoBehaviour
{
    public Vector3 destino;
    public float duracion = 2f;

    void Start()
    {
        // Iniciar la animaci�n de movimiento hacia la posici�n de destino
        transform.DOMove(destino, duracion);
    }
}
