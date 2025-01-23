using Cinemachine;
using UnityEngine;

public class ActivarRuido : MonoBehaviour
{
    public CinemachineVirtualCamera camaraVirtual;
    private CinemachineBasicMultiChannelPerlin ruido;
    private bool efectoActivado = false;

    void Start()
    {
        ruido = camaraVirtual.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        ruido.m_AmplitudeGain = 0; // Inicia sin ruido
    }

    void Update()
    {
        // Activa o desactiva el efecto de ruido al presionar la tecla E
        if (Input.GetKeyDown(KeyCode.E))
        {
            efectoActivado = !efectoActivado;
            ruido.m_AmplitudeGain = efectoActivado ? 2f : 0f; // Ajusta la intensidad del ruido
        }
    }
}
