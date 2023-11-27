using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorComida : MonoBehaviour
{
    
    //     { 0, "Durazno" },
    //     { 1, "Elote" },
    //     { 2, "Fresa" },
    //     { 3, "Galletas" },
    //     { 4, "Manzana" },
    //     { 5, "Naranja" },
    //     { 6, "Papaya" },
    //     { 7, "Piña" },
    //     { 8, "Platano" },
    //     { 9, "Sandia" },
    //     { 10, "Sandwich" },
    //     { 11, "Uvas" }

    public CrearPicto Pictograma, Foto1, Foto2, Foto3;
    public int NumPictograma, NumFoto1, NumFoto2, NumFoto3;
    public float tiempo = 0;

    // Start is called before the first frame update
    void Start()
    {
        NuevoJuego();
    }

    void Update() {
        tiempo += Time.deltaTime;    
    }

    public void NuevoJuego(){
        DefinirIndices();
        AsignarIndices();
    }

    public void DefinirIndices(){
        int[] indices = new int[3];

        // Define la foto 1
        indices[0] = UnityEngine.Random.Range(0, 12);
        NumFoto1 = indices[0];

        // Define la foto 2
        do{
            indices[1] = UnityEngine.Random.Range(0, 12);
        } while (indices[1] == indices[0]);
        NumFoto2 = indices[1];

        // Define la foto 3
        do{
            indices[2] = UnityEngine.Random.Range(0, 12);
        } while (indices[2] == indices[0] || indices[2] == indices[1]);
        NumFoto3 = indices[2];

        // Define el pictograma
        NumPictograma = indices[UnityEngine.Random.Range(0, 3)];
    }

    public void AsignarIndices(){
        Pictograma.DefinirSprite(NumPictograma);
        Foto1.DefinirSprite(NumFoto1);
        Foto2.DefinirSprite(NumFoto2);
        Foto3.DefinirSprite(NumFoto3);
    }

}
