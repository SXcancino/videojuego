using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class SelectNivelController : MonoBehaviour
{
    public Button comida1,comida2,comida3, atras;
    public Button juguete1,juguete2, juguete3;
    // Start is called before the first frame update
    void Start()
    {
        comida1.onClick.AddListener(() => {
            SceneManager.LoadScene("ComidaN1");
        });
        comida2.onClick.AddListener(() => {
            SceneManager.LoadScene("ComidaN2");
        });
        comida3.onClick.AddListener(() => {
            print("Ir a nivel 3 de Comida");
        });

        juguete1.onClick.AddListener(() => {
            print("Ir a nivel 1 de Juguetes");
        });

        juguete2.onClick.AddListener(() => {
            print("Ir a nivel 2 de Juguetes");
        });

        juguete3.onClick.AddListener(() => {
            print("Ir a nivel 3 de Juguetes");
        });

        atras.onClick.AddListener(() => {
            SceneManager.LoadScene("SelectPerfil");
        });
    }
}
