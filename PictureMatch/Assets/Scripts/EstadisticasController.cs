using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EstadisticasController : MonoBehaviour
{

    public Button atras;
    public Button buscar;
    public TMP_Dropdown niños;
    private string niñoSel;

    private DatabaseManager DB = new DatabaseManager();
    // Start is called before the first frame update
    void Start()
    {
        rellenarDropDown(niños);
        atras.onClick.AddListener(regresar);
        niños.onValueChanged.AddListener(OnDropdownValueChanged);
    }


    public void regresar(){
        SceneManager.LoadScene("MenuInicial");
    }

    public void rellenarDropDown(TMP_Dropdown x){
        List<KeyValuePair<string, string>> valores = DB.getNiños();
        List<TMP_Dropdown.OptionData> lista = new List<TMP_Dropdown.OptionData>();

        foreach (var n in valores){
            lista.Add(new TMP_Dropdown.OptionData(n.Key + " - " + n.Value));
        }
        
        x.AddOptions(lista);
    }

    void OnDropdownValueChanged(int value)
    {
        string input = this.niños.options[value].text.Replace(" ", "");
        // Encuentra la posición del punto
        int indiceGuion = input.IndexOf('-');

        // Toma la subcadena hasta el punto
        string subcadena = input.Substring(0, indiceGuion);
        
        this.niñoSel = subcadena;
    }

    void buscarStats(string n){

    }
}
