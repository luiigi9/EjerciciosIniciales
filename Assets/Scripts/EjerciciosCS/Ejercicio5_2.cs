using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 < 3 && numero2 < 3)
        {
            Debug.Log("Ambos numeros son menores que 3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
