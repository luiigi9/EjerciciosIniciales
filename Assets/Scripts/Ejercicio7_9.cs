using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    [SerializeField] int cuenta;
    int contador = 1;
    // Start is called before the first frame update
    void Start()
    {
        contador++;
        while (contador < cuenta)
        {
            if (contador % 3 == 0)
            {
                Debug.Log(contador);
            }
            contador++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
