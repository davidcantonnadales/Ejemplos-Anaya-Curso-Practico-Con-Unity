using UnityEngine;
using UnityEngine.UIElements;

public class LifeBarController : MonoBehaviour
{
    public UIDocument uiDocument;
    public VisualElement lifeBarFill;
    private float currentLife = 100f;
    private float maxLife = 100f;

    private void Start()
    {
        var root = uiDocument.rootVisualElement;
        lifeBarFill = root.Q<VisualElement>("Filling");
    }

    private void OnTriggerEnter(Collider other)
    {
        TakeDamage(20f); // Reduce la vida en 20 al colisionar
        print("Oh¡ He sido dañado...");
    }

    public void TakeDamage(float damage)
    {
        currentLife = Mathf.Max(currentLife - damage, 0); // Evita que la vida sea negativa
        UpdateLifeBar();
    }

    private void UpdateLifeBar()
    {
        float fillPercentage = currentLife / maxLife;
        lifeBarFill.style.width = new Length(fillPercentage * 100, LengthUnit.Percent);
    }
}
