using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ControladorRelacion : MonoBehaviour
{

    public GameObject Pictograma, Foto1, Foto2, Foto3, estrellas;
    public ControladorComida controladorComida;
    int puntos = 0;


    private void Start() {
        estrellas.GetComponent<TextMeshProUGUI>().text = puntos.ToString("0");
    }
    
    public void SelectFoto1(){
        if (controladorComida.NumFoto1 == controladorComida.NumPictograma){
            puntos += 1;
            estrellas.GetComponent<TextMeshProUGUI>().text = puntos.ToString();
            controladorComida.NuevoJuego();
            Foto2.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto3.GetComponent<UnityEngine.UI.Button>().interactable = true;
        } else{
            Foto1.GetComponent<UnityEngine.UI.Button>().interactable = false;
        }
    }

    public void SelectFoto2(){
        if (controladorComida.NumFoto2 == controladorComida.NumPictograma){
            puntos += 1;
            estrellas.GetComponent<TextMeshProUGUI>().text = puntos.ToString();
            controladorComida.NuevoJuego();
            Foto1.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto3.GetComponent<UnityEngine.UI.Button>().interactable = true;
        } else{
            Foto2.GetComponent<UnityEngine.UI.Button>().interactable = false;
        }
    }

    public void SelectFoto3(){
        if (controladorComida.NumFoto3 == controladorComida.NumPictograma){
            puntos += 1;
            estrellas.GetComponent<TextMeshProUGUI>().text = puntos.ToString();
            controladorComida.NuevoJuego();
            Foto1.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto2.GetComponent<UnityEngine.UI.Button>().interactable = true;
        } else{
            Foto3.GetComponent<UnityEngine.UI.Button>().interactable = false;
        }
    }

}
