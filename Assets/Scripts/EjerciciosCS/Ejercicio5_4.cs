using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] float dividendo, divisor;
    float resultado;
    // Start is called before the first frame update
    void Start()
    {
        if (divisor != 0)
        {
            resultado = dividendo / divisor;
            Debug.Log("El resultyado de la division es " + resultado);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
