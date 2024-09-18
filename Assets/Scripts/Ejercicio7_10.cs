using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField] int mayor, menor;
    int aux;
    string auxstring = "El numero ";
    // Start is called before the first frame update
    void Start()
    {
        if (mayor < menor)
        {
            aux = menor;
            menor = mayor;
            mayor = aux;
        }
        menor++;
        while (menor < mayor)
        {
            auxstring = "El numero ";
            if (menor % 2 == 0)
            {
                auxstring = auxstring + menor + " es un numero par y ";
            }
            else if (menor % 2 == 1 || menor % 2 == -1)
            {
                auxstring = auxstring + menor + " es un numero impar y ";
            }
            if (menor < 0)
            {
                auxstring = auxstring + "negativo";
            }
            else if (menor >= 0)
            {
                auxstring = auxstring + "positivo";
            }
            Debug.Log(auxstring);
            menor++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
