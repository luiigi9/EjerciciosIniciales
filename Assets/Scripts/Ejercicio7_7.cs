using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int mayor, menor;
    int aux=0;
    // Start is called before the first frame update
    void Start()
    {
        if (mayor < menor)
        {
            aux = menor;
            menor = mayor;
            mayor = aux;
        }
        while (menor < mayor + 1)
        {
            Debug.Log(menor);
            menor++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
