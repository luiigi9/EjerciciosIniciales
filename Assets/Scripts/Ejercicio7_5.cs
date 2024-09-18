using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int hasta;
    int contador = 1;
    // Start is called before the first frame update
    void Start()
    {
        while (contador < hasta)
        {
            Debug.Log(contador);
            contador++;
        }
        for (int i = 1; i < hasta; i++)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
