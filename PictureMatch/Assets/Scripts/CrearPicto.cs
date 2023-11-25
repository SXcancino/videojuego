using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class CrearPicto : MonoBehaviour
{
    public Sprite[] sprites;

    public void DefinirSprite(int indice){
        GetComponent<Image>().sprite = sprites[indice];
    }

}
