using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    float areaCir, areaT, areaCuad;
    // Start is called before the first frame update
    void Start()
    {
        areaCir = calcularCirculo(3);
        areaT = calcularTriamgulo(4, 6);
        areaCuad = calcularCuadrado(5);
        Debug.Log("El area del circulo es de " +  areaCir + " cm");
        Debug.Log("El area del triangulo es de " + areaT + " cm");
        Debug.Log("El area del cuadrado es de " + areaCuad + " cm");
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
}
