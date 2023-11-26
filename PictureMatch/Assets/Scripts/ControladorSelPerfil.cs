using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class botonTest : MonoBehaviour
{
    public Button botonJugar;

    public Button botonCrear;

    public Button atras;

    // Start is called before the first frame update
    void Start()
    {
        botonJugar.onClick.AddListener(play);
        botonCrear.onClick.AddListener(crearPerfilScene);
        atras.onClick.AddListener(regresar);
    }

    void play(){
        if(GlobalVariables.id == "null"){
            //Aqui va el modal que dice que no se puede jugar sin un perfil seleccionado
            print("No se puede jugar sin un perfil seleccionado");
        }
        else{
            SceneManager.LoadScene("Jugar");
        }
        
    }

    void crearPerfilScene(){
        SceneManager.LoadScene("CrearPerfil");
    }

    public void regresar(){
        SceneManager.LoadScene("MenuInicial");
    }
}
