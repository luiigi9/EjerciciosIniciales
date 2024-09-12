using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntos1;
    int puntos2;
    int puntos3;
    int media;
    // Start is called before the first frame update
    void Start()
    {
        puntos1 = 40;
        puntos2 = 62;
        puntos3 = 23;
        Debug.Log("Puntos HS: " + puntos1);
        Debug.Log("Puntos BS: " + puntos2);
        Debug.Log("Puntos LS: " + puntos3);
        media = (puntos1 + puntos2 + puntos3) / 3;
        Debug.Log("Media de puntos: " + media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
