using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int hasta;
    int contador;
    // Start is called before the first frame update
    void Start()
    {
        contador = hasta * -1;
        while (hasta > contador -1)
        {
            Debug.Log(hasta);
            hasta--;
        }
        for (int i = hasta; i > contador; i--)
        {
            Debug.Log(hasta);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
