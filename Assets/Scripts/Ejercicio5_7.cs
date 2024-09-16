using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int velocidad1, velocidad2, velocidad3;
    // Start is called before the first frame update
    void Start()
    {
        if(velocidad1 >= velocidad2 && velocidad1 >= velocidad3)
        {
            Debug.Log("El jugador 1 atacara primero");
        }
        else if (velocidad2 >= velocidad1 && velocidad2 >= velocidad3)
        {
            Debug.Log("El jugador 2 atacara primero");
        }
        else if (velocidad3 >= velocidad2 && velocidad3 >= velocidad1)
        {
            Debug.Log("El jugador 3 atacara primero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
