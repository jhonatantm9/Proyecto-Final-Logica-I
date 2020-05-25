using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Control_Niveles : MonoBehaviour
{
	//Se crean variables para cada botón de los niveles
	public Button nivel2, nivel3, nivel4, nivel5, nivel6, nivel7, nivel8, nivel9, nivel10;
	//nivel_completado guarda el último nivel completado, para permitir elegir un nivel superior
	int nivel_completado;

	// Use this for initialization
	void Start()
	{
		//El atributo NivelCompletado guarda el índice de la escena del último nivel completado
		nivel_completado = PlayerPrefs.GetInt("NivelCompletado");
		//Se desactivan los botones de los niveles a partir del 2 para evitar que se puedan jugar sin pasar los anteriores
		nivel2.interactable = false;
		nivel3.interactable = false;
		nivel4.interactable = false;
		nivel5.interactable = false;
		nivel6.interactable = false;
		nivel7.interactable = false;
		nivel8.interactable = false;
		nivel9.interactable = false;
		nivel10.interactable = false;

		//Este switch va activando los botones de los niveles de acuerdo a los niveles que se van completando
		switch (nivel_completado)
		{
			case 2:
				nivel2.interactable = true;
				break;
			case 3:
				nivel2.interactable = true;
				nivel3.interactable = true;
				break;
			case 4:
				nivel2.interactable = true;
				nivel3.interactable = true;
				nivel4.interactable = true;
				break;
			case 5:
				nivel2.interactable = true;
				nivel3.interactable = true;
				nivel4.interactable = true;
				nivel5.interactable = true;
				break;
			case 6:
				nivel2.interactable = true;
				nivel3.interactable = true;
				nivel4.interactable = true;
				nivel5.interactable = true;
				nivel6.interactable = true;
				break;
			case 7:
				nivel2.interactable = true;
				nivel3.interactable = true;
				nivel4.interactable = true;
				nivel5.interactable = true;
				nivel6.interactable = true;
				nivel7.interactable = true;
				break;
			case 8:
				nivel2.interactable = true;
				nivel3.interactable = true;
				nivel4.interactable = true;
				nivel5.interactable = true;
				nivel6.interactable = true;
				nivel7.interactable = true;
				nivel8.interactable = true;
				break;
			case 9:
				nivel2.interactable = true;
				nivel3.interactable = true;
				nivel4.interactable = true;
				nivel5.interactable = true;
				nivel6.interactable = true;
				nivel7.interactable = true;
				nivel8.interactable = true;
				nivel9.interactable = true;
				break;
			case 10:
				nivel2.interactable = true;
				nivel3.interactable = true;
				nivel4.interactable = true;
				nivel5.interactable = true;
				nivel6.interactable = true;
				nivel7.interactable = true;
				nivel8.interactable = true;
				nivel9.interactable = true;
				nivel10.interactable = true;
				break;
			case 11:
				nivel2.interactable = true;
				nivel3.interactable = true;
				nivel4.interactable = true;
				nivel5.interactable = true;
				nivel6.interactable = true;
				nivel7.interactable = true;
				nivel8.interactable = true;
				nivel9.interactable = true;
				nivel10.interactable = true;
				break;
		}
	}

	//Carga el nivel indicado en el entero nivel
	public void cargarNivel(int nivel)
	{
		SceneManager.LoadScene(nivel);
	}

	//Borra todos los botones activos, excepto el nivel 1 y resetea el atributo NivelCompletado en los PlayerPrefs
	public void resetearNiveles()
	{
		nivel2.interactable = false;
		nivel3.interactable = false;
		nivel4.interactable = false;
		nivel5.interactable = false;
		nivel6.interactable = false;
		nivel7.interactable = false;
		nivel8.interactable = false;
		nivel9.interactable = false;
		nivel10.interactable = false;
		PlayerPrefs.DeleteAll();
	}
}
