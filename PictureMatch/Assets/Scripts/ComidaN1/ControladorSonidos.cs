using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSonidos : MonoBehaviour
{

    public static ControladorSonidos InstanceCSonidos;
    private AudioSource audio;

    private void Awake() {
        if (InstanceCSonidos == null){
            InstanceCSonidos = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }

        audio = GetComponent<AudioSource>();
    }

    public void EjecutarSonido(AudioClip sonido){
        audio.PlayOneShot(sonido);
    }

}
