using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    float areaCir, areaT, areaCuad;
    float valorMonedas;
    // Start is called before the first frame update
    void Start()
    {
        areaCir = calcularCirculo(3);
        areaT = calcularTriamgulo(4, 6);
        areaCuad = calcularCuadrado(5);
        valorMonedas = convertir(areaCir, "dolares");
        Debug.Log("La conversion da el valor " + valorMonedas);
    }

    // Update is called once per frame
    void Update()
    {

    }
    float calcularCirculo(float radio)
    {
        float aux1;
        aux1 = radio * radio * 3.1416f;
        return aux1;
    }
    float calcularTriamgulo(float baseT, float alturaT)
    {
        float aux2;
        aux2 = baseT * alturaT / 2;
        return aux2;
    }
    float calcularCuadrado(float lado)
    {
        float aux3;
        aux3 = lado * lado;
        return aux3;
    }
    float convertir(float dinero, string moneda)
    {
        if (moneda == "euros")
        {
            dinero *= 1.11f;
        }
        if (moneda == "dolares")
        {
            dinero *= 0.9f;
        }
        return dinero;
    }
}

