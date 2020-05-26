
using UnityEngine;
using UnityEngine.Audio;

public class MenuAjustes : MonoBehaviour
{
   
    public static bool ajustes_activos = false;
    public AudioMixer mezclador; //Objeto a través del que está la salida de sonido

    private void Awake()
    {
        //Se ajusta el volumen al iniciar un nivel
        mezclador.SetFloat("Volumen", PlayerPrefs.GetFloat("VolumenActual"));
    }
    
    //Este método ajusta el volumen del mezclador y añade el valor al playerPrefs para usarlo en otras escenas
    public void cambiarVolumen(float volumen)
    {
        mezclador.SetFloat("Volumen", volumen);
        PlayerPrefs.SetFloat("VolumenActual", volumen);
    }
}
