using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PanelTerminarCN2 : MonoBehaviour
{
    public GameObject nAciertos, nErorres;
    public ControladorRelacionCN2 controladorRelacion;
    public AudioClip sndEEE;

    // Start is called before the first frame update
    void Start()
    {
        ControladorSonidos.InstanceCSonidos.EjecutarSonido(sndEEE);
        nAciertos.GetComponent<TextMeshProUGUI>().text = controladorRelacion.puntos.ToString();
        nErorres.GetComponent<TextMeshProUGUI>().text = controladorRelacion.errores.ToString();
    }

    public void TerminarPartida(){
        SceneManager.LoadScene("MenuInicial");
    }
}
