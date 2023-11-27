using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using Mono.Data.Sqlite;
using UnityEngine.SceneManagement;

public class CrearPerfilManager : MonoBehaviour
{
    private DatabaseManager DB = new DatabaseManager();
    public TMP_InputField id; 
    public TMP_InputField nombre;
    public Button submit;
    public Button atras;

    private void Start(){

        atras.onClick.AddListener(regresar);

        if(id != null && nombre != null){
            submit.onClick.AddListener(registrar);
        }
        else{
            print("Alguno de tus componentes es nulo");
            Application.Quit();
        }
    }

    public void registrar(){
        string id = this.id.text;
        string nombre = this.nombre.text;

        if(id == "" || nombre == ""){
            print("No puedes agregar un nombre que contenga campos vacios");
            return;
        }
        try{
            this.DB.addNiño(id, nombre);
            print("Niño agregado correctamente");
            SceneManager.LoadScene("SelectPerfil");
        }catch(SqliteException e){
            print("No se pueden repetir los ID");
            this.id.text = "";
        }catch(Exception ex){
            Debug.Log(ex, this);
        }
    }


    public void verRegistros(){
        List<KeyValuePair<string, string>> res = this.DB.getNiños();
        foreach (var registro in res)
        {
            Debug.Log($"Clave: {registro.Key}, Valor: {registro.Value}");
        }
    }

    public void regresar(){
        SceneManager.LoadScene("SelectPerfil");
    }
}
