using UnityEngine;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    // Elemento que representar� el men� lateral que queremos mostrar y ocultar
    private VisualElement menu;

    // �rea de detecci�n para activar el evento al pasar el rat�n
    private VisualElement detectionArea;

    private void Start()
    {
        // Obtenemos el rootVisualElement, que es el contenedor principal de la UI en el documento
        var root = GetComponent<UIDocument>().rootVisualElement;

        // Identificamos el men� y el �rea de detecci�n por su nombre
        menu = root.Q<VisualElement>("OptionsContainer"); // Aseg�rate de que el elemento en UI Builder se llama "OptionsContainer"
        detectionArea = root.Q<VisualElement>("MenuContainer"); // Aseg�rate de que el elemento en UI Builder se llama "MenuContainer"

        // Registramos el evento para mostrar el men� cuando el rat�n entra en el �rea de detecci�n
        detectionArea.RegisterCallback<MouseEnterEvent>(ev => ShowMenu());

        // Registramos el evento para ocultar el men� cuando el rat�n sale del �rea de detecci�n
        detectionArea.RegisterCallback<MouseLeaveEvent>(ev => HideMenu());
    }

    // M�todo para mostrar el men� configurando su visibilidad a Flex
    private void ShowMenu()
    {
        print("show menu");
        // Cambia el estilo display del men� a Flex para que se muestre en pantalla
        menu.style.visibility = Visibility.Visible;
    }

    // M�todo para ocultar el men� configurando su visibilidad a None
    private void HideMenu()
    {
        print("hide menu");
        // Cambia el estilo display del men� a None para que desaparezca de la pantalla
        menu.style.visibility = Visibility.Hidden;
    }
}
