using Cinemachine;
using UnityEngine;

public class CambiarCamara : MonoBehaviour
{
    public CinemachineVirtualCamera camaraPrincipal;
    public CinemachineVirtualCamera camaraAlternativa;
    private bool usandoCamaraPrincipal = true;

    void Update()
    {
        // Detecta si se ha presionado la tecla C
        if (Input.GetKeyDown(KeyCode.C))
        {
            CambiarPrioridad();
        }
    }

    void CambiarPrioridad()
    {
        // Alterna la prioridad de las cámaras
        if (usandoCamaraPrincipal)
        {
            camaraPrincipal.Priority = 0;
            camaraAlternativa.Priority = 10;
        }
        else
        {
            camaraPrincipal.Priority = 10;
            camaraAlternativa.Priority = 0;
        }

        // Cambia el estado de la cámara activa
        usandoCamaraPrincipal = !usandoCamaraPrincipal;
    }
}
