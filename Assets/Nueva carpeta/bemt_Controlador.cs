using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour {
    
    public void CambioEscena(string nombreLevel)
    {
        SceneManager.LoadScene(nombreLevel);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
