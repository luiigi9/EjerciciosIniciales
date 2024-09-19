using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] int nivel;
    int resto;
    // Start is called before the first frame update
    void Start()
    {
        resto = nivel % 2;
        if (resto == 0)
        {
            Debug.Log("El nivel del personaje es par");
        }
        else
        {
            Debug.Log("El nivel del personaje es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
