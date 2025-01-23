using UnityEngine;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    // Elemento que representará el menú lateral que queremos mostrar y ocultar
    private VisualElement menu;

    // Área de detección para activar el evento al pasar el ratón
    private VisualElement detectionArea;

    private void Start()
    {
        // Obtenemos el rootVisualElement, que es el contenedor principal de la UI en el documento
        var root = GetComponent<UIDocument>().rootVisualElement;

        // Identificamos el menú y el área de detección por su nombre
        menu = root.Q<VisualElement>("OptionsContainer"); // Asegúrate de que el elemento en UI Builder se llama "OptionsContainer"
        detectionArea = root.Q<VisualElement>("MenuContainer"); // Asegúrate de que el elemento en UI Builder se llama "MenuContainer"

        // Registramos el evento para mostrar el menú cuando el ratón entra en el área de detección
        detectionArea.RegisterCallback<MouseEnterEvent>(ev => ShowMenu());

        // Registramos el evento para ocultar el menú cuando el ratón sale del área de detección
        detectionArea.RegisterCallback<MouseLeaveEvent>(ev => HideMenu());
    }

    // Método para mostrar el menú configurando su visibilidad a Flex
    private void ShowMenu()
    {
        print("show menu");
        // Cambia el estilo display del menú a Flex para que se muestre en pantalla
        menu.style.visibility = Visibility.Visible;
    }

    // Método para ocultar el menú configurando su visibilidad a None
    private void HideMenu()
    {
        print("hide menu");
        // Cambia el estilo display del menú a None para que desaparezca de la pantalla
        menu.style.visibility = Visibility.Hidden;
    }
}
