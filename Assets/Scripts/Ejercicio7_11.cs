using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    [SerializeField] int numero;
    int conatdor = 0;
    // Start is called before the first frame update
    void Start()
    {
        while (conatdor < 11)
        {
            Debug.Log(numero + "x" + conatdor + " = " + numero * conatdor);
            conatdor++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
