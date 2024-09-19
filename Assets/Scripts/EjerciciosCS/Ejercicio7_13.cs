using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    [SerializeField] int entero;
    bool comprobacion = true;
    // Start is called before the first frame update
    void Start()
    {
        comprobacion = ComprobarPrimo(entero);
        if (comprobacion == false)
        {
            Debug.Log("El numero " + entero + " no es primo");
        }
        else
        {
            Debug.Log("El numero " + entero + " es primo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    bool ComprobarPrimo(int nuemero)
    {
        bool x = false;
        int aux = 1;
        int cuenta = 0;
        while (aux <= nuemero)
        {
            if(nuemero % aux == 0)
            {
                cuenta++;
            }
            aux++;
        }
        if (cuenta == 2)
        {
            x = true;
        }
        return x;
    }
}
