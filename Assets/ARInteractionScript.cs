using UnityEngine;

public class ARInteractionScript : MonoBehaviour
{
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        // Cambiar a un color aleatorio al tocar el objeto
        objectRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
