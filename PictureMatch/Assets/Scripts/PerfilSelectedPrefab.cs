using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PerfilSelectedPrefab : MonoBehaviour
{
    private Transform panel;
    public TMP_Text input;

    // Start is called before the first frame update
    void Start()
    {
        if(GlobalVariables.nombre == "null"){
            input.text = "";
        }
        else{
            input.text = GlobalVariables.nombre;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.nombre == "null")
        {
            input.text = "";
        }
        else
        {
            input.text = GlobalVariables.nombre;
        }
    }
}
