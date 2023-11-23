using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Move : MonoBehaviour
{
    public float velocidad = 25f;
    private Transform posicion;

    private void Start()
    {
        posicion = transform;
    }

    private void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        Vector3 desplazamiento = new Vector3(movHorizontal, movVertical, 0) * velocidad * Time.deltaTime;

        posicion.Translate(desplazamiento);
    }

    if((Input.GetKey(KeyCode.LeftControl)&&Input.GetKey(KeyCode.W))&& enSuelo){
            rdy.AddForce(Vector3.up * salto, ForceMode.Impulse);
            enSuelo = false;
        }

        if (transform.position.y >= 5.0f && !enSuelo){
            rdy.velocity = Vector3.zero;
            rdy.useGravity = false;
            enSuelo = true;
            Invoke("Elevar", 2.0f);
        }
    }

    void Elevar(){
        rdy.useGravity = true;
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Finish")){
            Time.timeScale = 0f;
        }
    }
}

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float velocidad = 25f;
    private Transform posicion;

    // Asumo que rdy, enSuelo y salto están declarados y definidos en tu clase
    private Rigidbody rdy;
    private bool enSuelo;
    public float salto = 10f;

    private void Start()
    {
        posicion = transform;
        rdy = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        Vector3 desplazamiento = new Vector3(movHorizontal, movVertical, 0) * velocidad * Time.deltaTime;

        posicion.Translate(desplazamiento);

        if((Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.W)) && enSuelo)
        {
            rdy.AddForce(Vector3.up * salto, ForceMode.Impulse);
            enSuelo = false;
        }

        if (transform.position.y >= 5.0f && !enSuelo)
        {
            rdy.velocity = Vector3.zero;
            rdy.useGravity = false;
            enSuelo = true;
            Invoke("Elevar", 2.0f);
        }
    }

    void Elevar()
    {
        rdy.useGravity = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Time.timeScale = 0f;
        }
    }
}

*/

public class Move : MonoBehaviour
{
    public float velocidad = 25f;
    private Transform posicion;

    // Asumo que rdy, enSuelo, y salto están declarados y definidos en tu clase
    private Rigidbody rdy;
    private bool enSuelo;
    public float salto = 10f;

    private void Start()
    {
        posicion = transform;
        rdy = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        Vector3 desplazamiento = new Vector3(movHorizontal, movVertical, 0) * velocidad * Time.deltaTime;

        posicion.Translate(desplazamiento);

        RealizarAccionesAdicionales(); // Llama al nuevo método para acciones adicionales
    }

    private void RealizarAccionesAdicionales()
    {
        if((Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.W)) && enSuelo)
        {
            rdy.AddForce(Vector3.up * salto, ForceMode.Impulse);
            enSuelo = false;
        }

        if (transform.position.y >= 5.0f && !enSuelo)
        {
            rdy.velocity = Vector3.zero;
            rdy.useGravity = false;
            enSuelo = true;
            Invoke("Elevar", 2.0f);
        }
    }

    void Elevar()
    {
        rdy.useGravity = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Time.timeScale = 0f;
        }
    }
}


