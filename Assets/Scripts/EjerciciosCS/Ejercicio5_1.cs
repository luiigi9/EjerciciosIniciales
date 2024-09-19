using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    int vida1, vida2;
    // Start is called before the first frame update
    void Start()
    {
        vida1 = 50;
        vida2 = 50;
        if (vida1 == vida2)
        {
            Debug.Log("La batalla si esta reñida");
        }
        else
        {
            Debug.Log("La batalla esta decantada hacia uno de los jugadores");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
