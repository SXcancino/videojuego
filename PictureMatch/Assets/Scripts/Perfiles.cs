using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perfil{
    public int id;
    public string nombre;

    public void GuardarPerfil() {
        string json = JsonUtility.ToJson(this);
        PlayerPrefs.SetString("Perfil" + id, json);
        PlayerPrefs.Save();
    }    

}

public class Perfiles : MonoBehaviour {

    private static Perfiles instance;

    public static Perfiles Instance {
        get {
            if (instance == null) {
                instance = FindObjectOfType<Perfiles>();
            }
            return instance;
        }
    }
    HashSet<int> idsPerfiles = new HashSet<int>();
    
    public void CrearNuevoPerfil(int id, string nombre) {
        if (!ExistePerfil(id)) {
            idsPerfiles.Add(id);
            Perfil nuevoPerfil = new Perfil();
            nuevoPerfil.id = id;
            nuevoPerfil.nombre = nombre;
            nuevoPerfil.GuardarPerfil();
        }
    }

    public void EliminarPerfil(int id) {
    if (ExistePerfil(id)) {
        idsPerfiles.Remove(id);
        PlayerPrefs.DeleteKey("Perfil_" + id);
    }
}

    public List<int> ObtenerIdsPerfiles() {
        return new List<int>(idsPerfiles);
    }

    public Perfil ObtenerPerfil(int id) {
        if (ExistePerfil(id)) {
            string json = PlayerPrefs.GetString("Perfil_" + id);
            if (!string.IsNullOrEmpty(json)) {
                return JsonUtility.FromJson<Perfil>(json);
            }
        }
        return null;
    }

    public bool ExistePerfil(int id) {
        return idsPerfiles.Contains(id);
    }

}