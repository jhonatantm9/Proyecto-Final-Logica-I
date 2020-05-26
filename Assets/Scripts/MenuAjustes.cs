using UnityEngine.UI;
using UnityEngine;

public class MenuAjustes : MonoBehaviour
{
    public GameObject menu_ajustes;
    public GameObject menu_pausa;
    public static bool ajustes_activos = false;

    public void mostrarAjustes()
    {
        ajustes_activos = true;
        menu_ajustes.SetActive(true);
    }

    public void ocultarAjustes()
    {
        ajustes_activos = false;
        menu_ajustes.SetActive(false);
    }

    public void mostrarMenuPausa()
    {
        menu_pausa.SetActive(true);
    }

    public void ocultarMenuPausa()
    {
        menu_pausa.SetActive(false);
    }

    public void cambiarMenu()
    {
        if (menu_pausa.activeSelf && !menu_ajustes.activeSelf)
        {
            menu_ajustes.SetActive(false);
            menu_pausa.SetActive(true);
        }
    }
}
