using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int mayor, menor;
    int aux = 0;
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
            if (menor % 2 == 0)
            {
                Debug.Log(menor);
            }
            menor++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
