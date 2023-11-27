using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public AudioClip sndBoton;
    public GameObject btnPausa;
    public GameObject menuPausa, panelTerminar;

    public void Pausa(){
        ControladorSonidos.InstanceCSonidos.EjecutarSonido(sndBoton);
        btnPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    public void Reanudar(){
        ControladorSonidos.InstanceCSonidos.EjecutarSonido(sndBoton);
        btnPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    public void Terminar(){
        panelTerminar.SetActive(true);
    }
}
