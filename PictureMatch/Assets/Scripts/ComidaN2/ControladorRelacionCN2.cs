using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorRelacionCN2 : MonoBehaviour
{
    public GameObject Pictograma, Foto1, Foto2, Foto3, Foto4, Foto5, estrellas, panelContinuar, panelTerminar;
    public ControladorComidaN2 controladorComida;
    public AudioClip sndEstrellitas, sndOhoh;
    public AudioClip[] sndComida;
    public int puntos = 0;
    public int errores = 0;


    void Start() {
        estrellas.GetComponent<TextMeshProUGUI>().text = puntos.ToString("0");
    }
    
    public void SelectFoto1(){
        if (controladorComida.NumFoto1 == controladorComida.NumPictograma){
            puntos += 1;
            estrellas.GetComponent<TextMeshProUGUI>().text = puntos.ToString();
            panelContinuar.SetActive(true);
            ControladorSonidos.InstanceCSonidos.EjecutarSonido(sndEstrellitas);
            controladorComida.NuevoJuego();
            Foto2.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto3.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto4.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto5.GetComponent<UnityEngine.UI.Button>().interactable = true;
        } else{
            ControladorSonidos.InstanceCSonidos.EjecutarSonido(sndOhoh);
            Foto1.GetComponent<UnityEngine.UI.Button>().interactable = false;
            errores += 1;
        }
    }

    public void SelectFoto2(){
        if (controladorComida.NumFoto2 == controladorComida.NumPictograma){
            puntos += 1;
            estrellas.GetComponent<TextMeshProUGUI>().text = puntos.ToString();
            panelContinuar.SetActive(true);
            ControladorSonidos.InstanceCSonidos.EjecutarSonido(sndEstrellitas);
            controladorComida.NuevoJuego();
            Foto1.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto3.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto4.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto5.GetComponent<UnityEngine.UI.Button>().interactable = true;
        } else{
            ControladorSonidos.InstanceCSonidos.EjecutarSonido(sndOhoh);
            Foto2.GetComponent<UnityEngine.UI.Button>().interactable = false;
            errores += 1;
        }
    }

    public void SelectFoto3(){
        if (controladorComida.NumFoto3 == controladorComida.NumPictograma){
            puntos += 1;
            estrellas.GetComponent<TextMeshProUGUI>().text = puntos.ToString();
            panelContinuar.SetActive(true);
            ControladorSonidos.InstanceCSonidos.EjecutarSonido(sndEstrellitas);
            controladorComida.NuevoJuego();
            Foto1.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto2.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto4.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto5.GetComponent<UnityEngine.UI.Button>().interactable = true;
        } else{
            ControladorSonidos.InstanceCSonidos.EjecutarSonido(sndOhoh);
            Foto3.GetComponent<UnityEngine.UI.Button>().interactable = false;
            errores += 1;
        }
    }

    public void SelectFoto4(){
        if (controladorComida.NumFoto4 == controladorComida.NumPictograma){
            puntos += 1;
            estrellas.GetComponent<TextMeshProUGUI>().text = puntos.ToString();
            panelContinuar.SetActive(true);
            ControladorSonidos.InstanceCSonidos.EjecutarSonido(sndEstrellitas);
            controladorComida.NuevoJuego();
            Foto1.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto3.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto2.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto5.GetComponent<UnityEngine.UI.Button>().interactable = true;
        } else{
            ControladorSonidos.InstanceCSonidos.EjecutarSonido(sndOhoh);
            Foto4.GetComponent<UnityEngine.UI.Button>().interactable = false;
            errores += 1;
        }
    }

    public void SelectFoto5(){
        if (controladorComida.NumFoto5 == controladorComida.NumPictograma){
            puntos += 1;
            estrellas.GetComponent<TextMeshProUGUI>().text = puntos.ToString();
            panelContinuar.SetActive(true);
            ControladorSonidos.InstanceCSonidos.EjecutarSonido(sndEstrellitas);
            controladorComida.NuevoJuego();
            Foto2.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto3.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto4.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Foto1.GetComponent<UnityEngine.UI.Button>().interactable = true;
        } else{
            ControladorSonidos.InstanceCSonidos.EjecutarSonido(sndOhoh);
            Foto5.GetComponent<UnityEngine.UI.Button>().interactable = false;
            errores += 1;
        }
    }

    public void BtnSonido(){
        ControladorSonidos.InstanceCSonidos.EjecutarSonido(sndComida[controladorComida.NumPictograma]);
    }
}
