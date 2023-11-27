using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PanelTerminar : MonoBehaviour
{
    public GameObject nAciertos, nErorres;
    public ControladorRelacion controladorRelacion;
    public ControladorComida controladorComida;
    public AudioClip sndEEE;
    public int totales, tiempo, exitosos, fallidos, nivel = 1;
    public string tipoNivel = "Comida";
    private string idNino = GlobalVariables.id;

    // Start is called before the first frame update
    void Start()
    {
        ControladorSonidos.InstanceCSonidos.EjecutarSonido(sndEEE);
        exitosos = controladorRelacion.puntos;
        fallidos = controladorRelacion.errores;
        nAciertos.GetComponent<TextMeshProUGUI>().text = exitosos.ToString();
        nErorres.GetComponent<TextMeshProUGUI>().text = fallidos.ToString();
        totales = controladorRelacion.puntos + controladorRelacion.errores;
        tiempo = (int)controladorComida.tiempo;
    }

    public void TerminarPartida(){
        SceneManager.LoadScene("MenuInicial");
    }

}
