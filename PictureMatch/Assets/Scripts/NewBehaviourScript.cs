using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        // Accede a la instancia del Perfiles (PerfilManager)
        Perfiles perfiles = Perfiles.Instance;

        if (perfiles != null)
        {
            List<int> idsPerfiles = perfiles.ObtenerIdsPerfiles();

            foreach (int id in idsPerfiles)
            {
                Debug.Log("ID de perfil: " + id);
                Perfil perfil = perfiles.ObtenerPerfil(id);
                if (perfil != null)
                {
                    Debug.Log("Perfil cargado: ID " + perfil.id + ", Nombre " + perfil.nombre);
                }
                else
                {
                    Debug.Log("No se pudo cargar el perfil con ID: " + id);
                }
            }
        }
        else
        {
            Debug.Log("No se encontró la instancia de Perfiles (PerfilManager)");
        }
    }
}
