using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    
    public void Jugar(){
        SceneManager.LoadScene("SelectPerfil");
    }

    public void Estadisticas(){
        SceneManager.LoadScene("Estadisticas");
    }

    public void Config(){
        SceneManager.LoadScene("Configuracion");
    }

    public void Salir(){
        Debug.Log("Salir...");
        Application.Quit();
    }

}
