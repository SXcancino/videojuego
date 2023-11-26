using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PerfilesContainer : MonoBehaviour
{
    public Transform contenedor;
    public GameObject caja;
    private DatabaseManager DB = new DatabaseManager();

    // Start is called before the first frame update
    void Start()
    {
        try{
            List<KeyValuePair<string, string>> res = this.DB.getNiños();

            contenedor = GetComponent<ScrollRect>().content;
            
        foreach( var perfiles in res){
            //Aqui el nombre que le dimos en el archivo
            var go = Instantiate(this.caja);

            //Aqui la clase
            var box = go.GetComponent<PerfilBox>();

            string idNiño = perfiles.Key;
            string nombreNiño = perfiles.Value;

            box.id.text = idNiño;
            box.nombre.text = nombreNiño;

            //Listeners
            box.select.onClick.AddListener(() => {
                GlobalVariables.id = idNiño;
                GlobalVariables.nombre = nombreNiño;
            });

            box.delete.onClick.AddListener(() => {
                try{
                    DB.eliminarNiño(idNiño);
                    print("Niño eliminado correctamente");
                    Destroy(go);
                }catch(Exception ex){
                    print("Error al eliminar");
                }
            });


            go.transform.SetParent(this.contenedor, false);
        }
        }catch(Exception e){
            print(e);
        }
        
    }

}
