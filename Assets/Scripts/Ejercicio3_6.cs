using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float velocidadKM;
    float velocidadMS;
    // Start is called before the first frame update
    void Start()
    {
        velocidadMS = velocidadKM * 1000 / 3600;
        Debug.Log(velocidadMS);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
