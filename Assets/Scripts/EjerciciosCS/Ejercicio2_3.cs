using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas;
    float exp;
    float producto;
    float cociente;
    float resto;
    int dobleV;
    float tripleE;
    // Start is called before the first frame update
    void Start()
    {
        vidas = 15;
        exp = 11.6f;
        producto = vidas * exp;
        cociente = vidas / exp;
        resto = vidas % exp;
        dobleV = vidas * 2;
        tripleE = exp * 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
