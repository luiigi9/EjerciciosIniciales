using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int numero;
    // Start is called before the first frame update
    void Start()
    {
        if (numero >= 0 && numero <= 9)
        {
            Debug.Log("Si es un numero entero comprendido entre 0 y 9");
        }
        else
        {
            Debug.Log("No es un numero entero comprendido entre 0 y 9");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
