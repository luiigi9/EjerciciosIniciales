using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float baseT, alturaT;
    float areaT;
    // Start is called before the first frame update
    void Start()
    {
        areaT = (baseT*alturaT) / 2;
        Debug.Log(areaT);
    }
 
    // Update is called once per frame
    void Update()
    {
        
    }
}
