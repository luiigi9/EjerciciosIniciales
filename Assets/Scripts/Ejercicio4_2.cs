using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    string datosPersonas;
    // Start is called before the first frame update
    void Start()
    {
        datosPersonas = "La persona se llama " + construirNombre("Pepe", "Rodirguez", "Jimenez", 20) + " años";
        Debug.Log(datosPersonas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string construirNombre(string nombre, string apellido1, string apellido2, int edad)
    {
        string aux1;
        aux1 = nombre + " " + apellido1 + " " + apellido2 + " y tiene " + edad;
        return aux1;
    }
}
