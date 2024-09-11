using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas;
    float exp;
    char carac;
    float resultadoSuma;
    float resultadoResta;
    // Start is called before the first frame update
    void Start()
    {
        vidas = 10;
        exp = 20.4f;
        carac = 'a';
        Debug.Log("vidas: " + vidas);
        Debug.Log("exp: " + exp);
        resultadoSuma = vidas + exp;
        resultadoResta = exp - vidas;
        Debug.Log("El resultado de la suma es " + resultadoSuma);
        Debug.Log("El resultado de la resta es " + resultadoResta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
