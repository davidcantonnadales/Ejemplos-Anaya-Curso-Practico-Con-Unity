using UnityEngine;

public class Life : MonoBehaviour
{
    public float health = 100f;

    private void OnGUI()
    {
        if (health <= 0)
        {
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "Has muerto");
        }
    }
}
