using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio;
    float longitudC, areaC;
    // Start is called before the first frame update
    void Start()
    {
        longitudC = 2 * 3.1416f * radio;
        areaC = 3.1416f * radio * radio;
        Debug.Log(longitudC);
        Debug.Log(areaC);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
