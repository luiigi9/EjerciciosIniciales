using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1;
    int vidasPlayer2;
    int vidasPlayer3;
    int vidasPlayer4;
    // Start is called before the first frame update
    void Start()
    {
        vidasPlayer1 = 5;
        vidasPlayer2 = 7;
        vidasPlayer3 = 2;
        vidasPlayer4 = 13;
        vidasPlayer2 = vidasPlayer3;
        Debug.Log("vidas: " + vidasPlayer2);
        vidasPlayer3 = vidasPlayer1;
        Debug.Log("vidas: " + vidasPlayer3);
        vidasPlayer1 = vidasPlayer4;
        Debug.Log("vidas: " + vidasPlayer1);
        vidasPlayer4 = vidasPlayer2;
        Debug.Log("vidas: " + vidasPlayer4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
