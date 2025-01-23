using System.Collections;
using UnityEngine;

public class DesplazamientoConCoroutine : MonoBehaviour
{
    public Vector3 destino;
    public float duracion = 2f;

    void Start()
    {
        StartCoroutine(AnimarMovimiento(destino, duracion));
    }

    IEnumerator AnimarMovimiento(Vector3 destino, float duracion)
    {
        Vector3 inicio = transform.position;
        float tiempoTranscurrido = 0;

        while (tiempoTranscurrido < duracion)
        {
            transform.position = Vector3.Lerp(inicio, destino, tiempoTranscurrido / duracion);
            tiempoTranscurrido += Time.deltaTime;
            yield return null;
        }

        transform.position = destino;
    }

}
