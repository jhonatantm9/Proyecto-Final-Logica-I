using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Pausa : MonoBehaviour
{
    //Esta variable guarda un booleano que representa si el juego está o no pausado
    public static bool juego_pausado = false;
    //Esta variable hace referencia al panel con el menú de pausa y los botones
    public GameObject menu_pausa;

    // Update is called once per frame
    void Update()
    {
        //Si presiona la tecla Escape, se ejecuta la línea de código para el menú de pausa
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Condicional para cuando se presiona y el juego ya estaba pausado
            if (juego_pausado)
            {
                ContinuarJuego();
            }
            //Si el juego no estaba en pausa, se ejecuta este bloque
            else
            {
                PausarJuego();
            }
        }
    }

    //Método que continua el juego, después de haber pausado
    public void ContinuarJuego()
    {
        menu_pausa.SetActive(false);
        Time.timeScale = 1f; //Continúa el tiempo normal, para que el nivel siga igual
        juego_pausado = false;
    }

    //Método que pausa el juego y abre el menú de pausa
    public void PausarJuego()
    {
        menu_pausa.SetActive(true);
        Time.timeScale = 0f; //Congela el tiempo para que no se muevan los objetos del nivel
        juego_pausado = true;
    }

    //Método que carga la escena del menú principal
    public void CargarMenu()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    //Método que sale del juego
    public void Salir()
    {
        Application.Quit();
    }
}
