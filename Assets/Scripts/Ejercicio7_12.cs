using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    [SerializeField] int num1, num2;
    int total;
    // Start is called before the first frame update
    void Start()
    {
        total = sumarTodosLosNumeros(num1, num2);
        Debug.Log(total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int sumarTodosLosNumeros(int numero1, int numero2)
    {
        int suma = 0;
        while (numero1 <= numero2 ) {
            suma += numero1;
            numero1++;
        }
        return suma;
    }
}
