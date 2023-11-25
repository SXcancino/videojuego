using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class CrearPicto : MonoBehaviour
{

    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        DefinirSprite();
    }

    public void DefinirSprite(){      
        GetComponent<Image>().sprite = sprites[Random.Range(0, sprites.Length)];
    }

}
