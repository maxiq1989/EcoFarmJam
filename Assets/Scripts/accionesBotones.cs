using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class accionesBotones : MonoBehaviour
{
    // Start is called before the first frame update
    public void iniciarJuego()
    {
        Time.timeScale = 1; // Reanuda el juego a velocidad normal.
        SceneManager.LoadScene(1);
    }
    public void instrucciones()
    {
        SceneManager.LoadScene(2);
    }
    public void cerrarJuego()
    {
        Application.Quit();
    }
    public void regresarInicio()
    {
        SceneManager.LoadScene(0);
    }
    public void irAlNivel1()
    {
        Time.timeScale = 1; // Reanuda el juego a velocidad normal.
        SceneManager.LoadScene(2);
    }
    public void irAlNivel2()
    {
        Time.timeScale = 1; // Reanuda el juego a velocidad normal.
        SceneManager.LoadScene(3);
    }
    public void irAlNivel3()
    {
        Time.timeScale = 1; // Reanuda el juego a velocidad normal.
        SceneManager.LoadScene(4);
    }
    public void irAlNivel4()
    {
        Time.timeScale = 1; // Reanuda el juego a velocidad normal.
        SceneManager.LoadScene(5);
    }
    public void irAlNivel5()
    {
        Time.timeScale = 1; // Reanuda el juego a velocidad normal.
        SceneManager.LoadScene(6);
    }
}
