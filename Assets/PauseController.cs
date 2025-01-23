using UnityEngine;
using UnityEngine.UIElements;

public class PauseController : MonoBehaviour
{
    private bool isPaused = false;

    public Button pauseButton;

    private void Start()
    {
        UnityEngine.Cursor.visible = true;
        UnityEngine.Cursor.lockState = CursorLockMode.None;
        // Encuentra y asigna el elemento visual de la barra
        var root = GetComponent<UIDocument>().rootVisualElement;
        pauseButton = root.Q<Button>("PauseButton");

        pauseButton.clicked += TogglePause;
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;

        print("El juego está pausado: " + isPaused.ToString());
    }
}
