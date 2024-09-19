using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    float velocidadKm;
    // Start is called before the first frame update
    void Start()
    {
        velocidadKm = deKmaMs(130);
        Debug.Log("La velocidad introducida en Km/h es igual a " + velocidadKm + "m/s");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float deKmaMs(float valor)
    {
        valor = valor * 1000 / 3600;
        return valor;
    }
}
