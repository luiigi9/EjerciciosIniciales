using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int nivelPoke;
    int resto;
    // Start is called before the first frame update
    void Start()
    {
        resto = nivelPoke % 10;
        if (resto == 0)
        {
            Debug.Log("El pokemon puede aprender un nuevo ataque");
        }
        else
        {
            Debug.Log("El pokemon no puede aprender un nuevo ataque todavia");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
