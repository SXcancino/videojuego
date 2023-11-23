using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour
{
   
    public GameObject cubo;
   
    public int cantidad = 4;

    void Start()
    {
        GenerarCubos();
    }
    void GenerarCubos()
    {
        for (int i = 0; i < cantidad; i++)
        {
            Vector3 posicionAleatoria = ObtenerPosicionAleatoria();
            Instantiate(cubo, posicionAleatoria, Quaternion.identity);
        }
    }

    Vector3 ObtenerPosicionAleatoria()
    {
        float x = Random.Range(-40f, 40f);
        float z = Random.Range(-40f, 40f);
        return new Vector3(x, 5f, z);
    }
}
