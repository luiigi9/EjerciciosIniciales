using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    float cantidad;
    string tipoM;
    float conversion;
    
    // Start is called before the first frame update
    void Start()
    {
        tipoM = "dolares";
        cantidad = 43;
        conversion = convertir(cantidad, tipoM);
        if (tipoM == "euros")
        {
            Debug.Log(cantidad + " " + tipoM + " en dolares son " + conversion);
        }
        if (tipoM == "dolares")
        {
            Debug.Log(cantidad + tipoM + "en euros son " + conversion);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float convertir(float dinero, string moneda)
    {
        if (moneda == "euros")
        {
            dinero *= 1.11f;
        }
        if (moneda == "dolares")
        {
            dinero *= 0.9f;
        }
        return dinero;
    }
}
