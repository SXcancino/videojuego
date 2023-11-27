using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorComidaN2 : MonoBehaviour
{
    public CrearPicto Pictograma, Foto1, Foto2, Foto3, Foto4, Foto5;
    public int NumPictograma, NumFoto1, NumFoto2, NumFoto3, NumFoto4, NumFoto5;

    // Start is called before the first frame update
    void Start()
    {
        NuevoJuego();
    }

    public void NuevoJuego(){
        DefinirIndices();
        AsignarIndices();
    }

    public void DefinirIndices(){
        int[] indices = new int[5];

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

        // Define la foto 4
        do{
            indices[3] = UnityEngine.Random.Range(0, 12);
        } while (indices[3] == indices[0] || indices[3] == indices[1] || indices[3] == indices[2]);
        NumFoto4 = indices[3];

        // Define la foto 5
        do{
            indices[4] = UnityEngine.Random.Range(0, 12);
        } while (indices[4] == indices[0] || indices[4] == indices[1] || indices[4] == indices[2] || indices[4] == indices[3]);
        NumFoto5 = indices[4];

        // Define el pictograma
        NumPictograma = indices[UnityEngine.Random.Range(0, 3)];
    }

    public void AsignarIndices(){
        Pictograma.DefinirSprite(NumPictograma);
        Foto1.DefinirSprite(NumFoto1);
        Foto2.DefinirSprite(NumFoto2);
        Foto3.DefinirSprite(NumFoto3);
        Foto4.DefinirSprite(NumFoto4);
        Foto5.DefinirSprite(NumFoto5);
    }
}
