using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vida;
    float vidaF;
    // Start is called before the first frame update
    void Start()
    {
        vida = 120;
        vidaF = vida;
        Debug.Log(vida);
        vidaF = 120 * 0.03f;
        vida -= vidaF;
        Debug.Log(vida);
        vidaF = 120 * 0.06f;
        vida -= vidaF;
        Debug.Log(vida);
        vidaF = 120 * 0.09f;
        vida -= vidaF;
        Debug.Log(vida);
        vidaF = 120 * 0.12f;
        vida -= vidaF;
        Debug.Log(vida);
        vidaF = 120 * 0.15f;
        vida -= vidaF;
        Debug.Log(vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
