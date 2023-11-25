using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botonTest : MonoBehaviour
{
    public Button boton;
    // Start is called before the first frame update
    void Start()
    {
        boton.onClick.AddListener(hola);
    }

    void hola(){
        print("La sesion actual pertenece a " + GlobalVariables.nombre);
    }
}
