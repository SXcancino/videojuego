using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelContinuar : MonoBehaviour
{
    public AudioClip sndBoton;
    public GameObject panelContinuar;

    public void Continuar(){
        ControladorSonidos.InstanceCSonidos.EjecutarSonido(sndBoton);
        panelContinuar.SetActive(false);
    }
}
