using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    public float velocidad = 5.0f;
    public float tiempoCambioDireccion = 1.5f;
    private float tiempoPasado = 0.0f;
    private Vector3 direccion;
    void Start()
    {
        CambiarDireccion();
    }

    // Update is called once per frame
    void Update()
    {
        tiempoPasado += Time.deltaTime;

        if(tiempoPasado > tiempoCambioDireccion){
            CambiarDireccion();
            tiempoPasado = 0.0f;
        }

        transform.position += direccion * velocidad * Time.deltaTime;
    }

    void CambiarDireccion(){
        direccion = new Vector3(Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f));
    }
}
